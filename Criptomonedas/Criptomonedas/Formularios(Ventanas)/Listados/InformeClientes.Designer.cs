namespace Criptomonedas.Formularios_Ventanas_.Listados
{
    partial class InformeClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMinimizarPantallaABMCLiente = new FontAwesome.Sharp.IconButton();
            this.btnCerrarPantallaABMCliente = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblModificar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewerClientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinimizarPantallaABMCLiente
            // 
            this.btnMinimizarPantallaABMCLiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizarPantallaABMCLiente.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMinimizarPantallaABMCLiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimizarPantallaABMCLiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarPantallaABMCLiente.FlatAppearance.BorderSize = 0;
            this.btnMinimizarPantallaABMCLiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarPantallaABMCLiente.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizarPantallaABMCLiente.IconColor = System.Drawing.SystemColors.Control;
            this.btnMinimizarPantallaABMCLiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizarPantallaABMCLiente.IconSize = 20;
            this.btnMinimizarPantallaABMCLiente.Location = new System.Drawing.Point(731, 1);
            this.btnMinimizarPantallaABMCLiente.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizarPantallaABMCLiente.Name = "btnMinimizarPantallaABMCLiente";
            this.btnMinimizarPantallaABMCLiente.Size = new System.Drawing.Size(34, 20);
            this.btnMinimizarPantallaABMCLiente.TabIndex = 71;
            this.btnMinimizarPantallaABMCLiente.UseVisualStyleBackColor = false;
            // 
            // btnCerrarPantallaABMCliente
            // 
            this.btnCerrarPantallaABMCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarPantallaABMCliente.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCerrarPantallaABMCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrarPantallaABMCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarPantallaABMCliente.FlatAppearance.BorderSize = 0;
            this.btnCerrarPantallaABMCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPantallaABMCliente.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrarPantallaABMCliente.IconColor = System.Drawing.SystemColors.Control;
            this.btnCerrarPantallaABMCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarPantallaABMCliente.IconSize = 30;
            this.btnCerrarPantallaABMCliente.Location = new System.Drawing.Point(765, 1);
            this.btnCerrarPantallaABMCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarPantallaABMCliente.Name = "btnCerrarPantallaABMCliente";
            this.btnCerrarPantallaABMCliente.Size = new System.Drawing.Size(34, 20);
            this.btnCerrarPantallaABMCliente.TabIndex = 70;
            this.btnCerrarPantallaABMCliente.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblModificar);
            this.panel1.Controls.Add(this.btnCerrarPantallaABMCliente);
            this.panel1.Controls.Add(this.btnMinimizarPantallaABMCLiente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 70);
            this.panel1.TabIndex = 73;
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Font = new System.Drawing.Font("Bauhaus 93", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblModificar.Location = new System.Drawing.Point(2, 9);
            this.lblModificar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(270, 30);
            this.lblModificar.TabIndex = 17;
            this.lblModificar.Text = "Informe de Clientes";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewerClientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 380);
            this.panel2.TabIndex = 74;
            // 
            // reportViewerClientes
            // 
            this.reportViewerClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerClientes.Location = new System.Drawing.Point(0, 0);
            this.reportViewerClientes.Name = "reportViewerClientes";
            this.reportViewerClientes.ServerReport.BearerToken = null;
            this.reportViewerClientes.Size = new System.Drawing.Size(800, 380);
            this.reportViewerClientes.TabIndex = 0;
            // 
            // InformeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformeClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformeClientes";
            this.Load += new System.EventHandler(this.InformeClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnMinimizarPantallaABMCLiente;
        private FontAwesome.Sharp.IconButton btnCerrarPantallaABMCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerClientes;
        private System.Windows.Forms.Label lblModificar;
    }
}