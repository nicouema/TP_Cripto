using Criptomonedas.Entidades;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptomonedas
{
    // ------------------- DISEÑO DE GUI ------------------------

    public partial class Form1 : Form
    {
        private int tamañoBorde = 2;
        private Size formSize;

        public Form1(Usuario usu)
        {
            InitializeComponent();
            this.Padding = new Padding(tamañoBorde);
            this.BackColor = Color.White;
            ColapsarMenu();
            txtLabelUsuario.Text = usu.User.ToString();
        }

       


        // -- Arrastrar Formulario (desde panel Dashboard)

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        // -- Configuración Ventana de Windows (Ajustes manuales desde bordes sin perdida de formato de contenedores)

        // En el siguiente código se pueden ver funciones con respecto a la manejabilidad de la ventanas de windows como por ejemplo
        // ajustar la ventana cuando la arrastras hacia un borde de tu pantalla, eliminar los bordes de la ventana, etc.
        // Es mas un copy-paste que otra cosa.

        // Está comentado todo por el tipo de donde sacamos el diseño asique mas o menos se puede entender a que hace referencia.
        // Explico muy breve. Primero llama a constantes que Windows las define a cada una como una función particular para sus ventanas.
        // More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest Ahí esta la info que Windows brinda explicando cada constante.
        
        // Después, cada condición 'if' interactúa con esas constantes y mas o menos los comentarios hablan de lo que hace el código interviniente.
        // Estos comentarios luego los sacamos, los dejo para que vean y tengan a mano esta información ya que se ve re util para trabajar.
        // Sin todas estas funciones nuestra ventana sería muy simple, sin poder interactuar mucho con ella.

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            // Acá por ejemplo es para eliminar el borde con los botones de cerrar, maximizar y minimizar. Para diseñar nuestros propios botones.
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        // -- Ajustar Formulario
        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }


        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Normal:
                    if (this.Padding.Top != tamañoBorde)
                    {
                        this.Padding = new Padding(tamañoBorde);
                    }
                    break;
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                default:
                    break;
            }
        }





        // ------------------------ FUNCIONES AUXILIARES ----------------------

        // -- Estructura de SubMenu de Botones Principales

        private void Open_DropdownMenu(RJDropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            dropdownMenu.VisibleChanged += new EventHandler((sender2, ev)
            => DropdownMenu_VisibleChanged(sender2, ev, control));
            dropdownMenu.Show(control, control.Width, 0);
        }

        private void DropdownMenu_VisibleChanged(object sender, EventArgs e, Control ctrl)
        {
            RJDropdownMenu dropdownMenu = (RJDropdownMenu)sender;
            if (!DesignMode)
            {
                if (dropdownMenu.Visible)
                    ctrl.BackColor = Color.FromArgb(159, 161, 224);
                else ctrl.BackColor = Color.FromArgb(98, 102, 244);
            }
        }
        







        // -------------------------- BOTONES -------------------------


        // -- Botón Menú Lateral (Apertura y Cierre)

        private void btnLateralMenu_Click(object sender, EventArgs e)
        {
            ColapsarMenu();
        }

        private void ColapsarMenu()
        {
            // Menu Colapsado
            if (this.panelMenu.Width > 171)
            {
                panelMenu.Width = 100;
                pictureBoxLogo.Visible = false;
                btnLateralMenu.Dock = DockStyle.Top;
                foreach (Button btnMenu in panelMenu.Controls.OfType<Button>())
                {
                    btnMenu.Text = "";
                    btnMenu.ImageAlign = ContentAlignment.MiddleCenter;
                    btnMenu.Padding = new Padding(0);
                }

            }
            // Menu Expandido
            else
            {
                panelMenu.Width = 173;
                pictureBoxLogo.Visible = true;
                btnLateralMenu.Dock = DockStyle.None;
                foreach (Button btnMenu in panelMenu.Controls.OfType<Button>())
                {
                    btnMenu.Text = "   " + btnMenu.Tag.ToString();
                    btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
                    btnMenu.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }


        // -- Botón Minimizar Ventana
        private void btnMinimizarPantalla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        // -- Botón Maximizar Ventana
        private void btnMaximizarPantalla_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }

            else
            {
                this.WindowState = FormWindowState.Normal;
                this.ClientSize = formSize;
            }

        }

        // -- Botón Cerrar Ventana
        private void btnCerrarPantalla_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // -- Funciones de Botones Principales(Falta)        

        private void btnABM1_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(subMenu1, sender);
        }

        private void subMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

//      Alta Pais
        private void btnAltaPais_Click(object sender, EventArgs e)
        {

        }

        private void btnAltaProvincia_Click(object sender, EventArgs e)
        {

        }

        private void btnAltaCiudad_Click(object sender, EventArgs e)
        {

        }

        private void btnAltaBarrio_Click(object sender, EventArgs e)
        {

        }

        private void btnCodArea_Click(object sender, EventArgs e)
        {

        }

        private void btnTipoDocumento_Click(object sender, EventArgs e)
        {

        }
    }
}
