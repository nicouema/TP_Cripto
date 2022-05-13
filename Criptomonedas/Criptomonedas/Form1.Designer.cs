using System;

namespace Criptomonedas
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnABM3 = new FontAwesome.Sharp.IconButton();
            this.btnABM2 = new FontAwesome.Sharp.IconButton();
            this.btnABM1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLateralMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.txtLabelUsuario = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.btnMinimizarPantalla = new FontAwesome.Sharp.IconButton();
            this.btnMaximizarPantalla = new FontAwesome.Sharp.IconButton();
            this.btnCerrarPantalla = new FontAwesome.Sharp.IconButton();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.subMenu1 = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.btnAltaPais = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAltaProvincia = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAltaCiudad = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAltaBarrio = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCodArea = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTipoDocumento = new System.Windows.Forms.ToolStripMenuItem();
            this.rjDropdownMenu1 = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.rjDropdownMenu2 = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.rjDropdownMenu3 = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.rjDropdownMenu4 = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.subMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panelMenu.Controls.Add(this.btnABM3);
            this.panelMenu.Controls.Add(this.btnABM2);
            this.panelMenu.Controls.Add(this.btnABM1);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(172, 442);
            this.panelMenu.TabIndex = 0;
            // 
            // btnABM3
            // 
            this.btnABM3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnABM3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABM3.FlatAppearance.BorderSize = 0;
            this.btnABM3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABM3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABM3.ForeColor = System.Drawing.Color.Black;
            this.btnABM3.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.btnABM3.IconColor = System.Drawing.Color.Black;
            this.btnABM3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnABM3.IconSize = 40;
            this.btnABM3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnABM3.Location = new System.Drawing.Point(0, 220);
            this.btnABM3.Name = "btnABM3";
            this.btnABM3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnABM3.Size = new System.Drawing.Size(172, 60);
            this.btnABM3.TabIndex = 2;
            this.btnABM3.Tag = "ABM3";
            this.btnABM3.Text = "ABM3";
            this.btnABM3.UseVisualStyleBackColor = true;
            // 
            // btnABM2
            // 
            this.btnABM2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnABM2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABM2.FlatAppearance.BorderSize = 0;
            this.btnABM2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABM2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABM2.ForeColor = System.Drawing.Color.Black;
            this.btnABM2.IconChar = FontAwesome.Sharp.IconChar.GetPocket;
            this.btnABM2.IconColor = System.Drawing.Color.Black;
            this.btnABM2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnABM2.IconSize = 40;
            this.btnABM2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnABM2.Location = new System.Drawing.Point(0, 160);
            this.btnABM2.Name = "btnABM2";
            this.btnABM2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnABM2.Size = new System.Drawing.Size(172, 60);
            this.btnABM2.TabIndex = 1;
            this.btnABM2.Tag = "ABM2";
            this.btnABM2.Text = "ABM2";
            this.btnABM2.UseVisualStyleBackColor = true;
            // 
            // btnABM1
            // 
            this.btnABM1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnABM1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABM1.FlatAppearance.BorderSize = 0;
            this.btnABM1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABM1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABM1.ForeColor = System.Drawing.Color.Black;
            this.btnABM1.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.btnABM1.IconColor = System.Drawing.Color.Black;
            this.btnABM1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnABM1.IconSize = 40;
            this.btnABM1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnABM1.Location = new System.Drawing.Point(0, 100);
            this.btnABM1.Name = "btnABM1";
            this.btnABM1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnABM1.Size = new System.Drawing.Size(172, 60);
            this.btnABM1.TabIndex = 0;
            this.btnABM1.Tag = "Alta datos de usuario";
            this.btnABM1.Text = "Alta datos de usuario";
            this.btnABM1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnABM1.UseVisualStyleBackColor = true;
            this.btnABM1.Click += new System.EventHandler(this.btnABM1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLateralMenu);
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnLateralMenu
            // 
            this.btnLateralMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnLateralMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLateralMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLateralMenu.FlatAppearance.BorderSize = 0;
            this.btnLateralMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLateralMenu.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLateralMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnLateralMenu.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLateralMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLateralMenu.IconSize = 30;
            this.btnLateralMenu.Location = new System.Drawing.Point(128, 0);
            this.btnLateralMenu.Name = "btnLateralMenu";
            this.btnLateralMenu.Size = new System.Drawing.Size(45, 49);
            this.btnLateralMenu.TabIndex = 1;
            this.btnLateralMenu.UseVisualStyleBackColor = false;
            this.btnLateralMenu.Click += new System.EventHandler(this.btnLateralMenu_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(118, 49);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Black;
            this.panelTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTitulo.Controls.Add(this.txtLabelUsuario);
            this.panelTitulo.Controls.Add(this.lblDashboard);
            this.panelTitulo.Controls.Add(this.btnMinimizarPantalla);
            this.panelTitulo.Controls.Add(this.btnMaximizarPantalla);
            this.panelTitulo.Controls.Add(this.btnCerrarPantalla);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(172, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(762, 49);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown_1);
            // 
            // txtLabelUsuario
            // 
            this.txtLabelUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLabelUsuario.AutoSize = true;
            this.txtLabelUsuario.Font = new System.Drawing.Font("Bauhaus 93", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelUsuario.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtLabelUsuario.Location = new System.Drawing.Point(603, 25);
            this.txtLabelUsuario.Name = "txtLabelUsuario";
            this.txtLabelUsuario.Size = new System.Drawing.Size(66, 21);
            this.txtLabelUsuario.TabIndex = 0;
            this.txtLabelUsuario.Text = "label1";
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboard.Font = new System.Drawing.Font("Bauhaus 93", 15F, System.Drawing.FontStyle.Bold);
            this.lblDashboard.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblDashboard.Location = new System.Drawing.Point(22, 15);
            this.lblDashboard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(131, 23);
            this.lblDashboard.TabIndex = 4;
            this.lblDashboard.Text = "DASHBOARD";
            this.lblDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimizarPantalla
            // 
            this.btnMinimizarPantalla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizarPantalla.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMinimizarPantalla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimizarPantalla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarPantalla.FlatAppearance.BorderSize = 0;
            this.btnMinimizarPantalla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimizarPantalla.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizarPantalla.IconColor = System.Drawing.SystemColors.Control;
            this.btnMinimizarPantalla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizarPantalla.IconSize = 20;
            this.btnMinimizarPantalla.Location = new System.Drawing.Point(661, 0);
            this.btnMinimizarPantalla.Name = "btnMinimizarPantalla";
            this.btnMinimizarPantalla.Size = new System.Drawing.Size(34, 20);
            this.btnMinimizarPantalla.TabIndex = 3;
            this.btnMinimizarPantalla.UseVisualStyleBackColor = false;
            this.btnMinimizarPantalla.Click += new System.EventHandler(this.btnMinimizarPantalla_Click);
            // 
            // btnMaximizarPantalla
            // 
            this.btnMaximizarPantalla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizarPantalla.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMaximizarPantalla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMaximizarPantalla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizarPantalla.FlatAppearance.BorderSize = 0;
            this.btnMaximizarPantalla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMaximizarPantalla.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizarPantalla.IconColor = System.Drawing.SystemColors.Control;
            this.btnMaximizarPantalla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizarPantalla.IconSize = 20;
            this.btnMaximizarPantalla.Location = new System.Drawing.Point(694, 0);
            this.btnMaximizarPantalla.Name = "btnMaximizarPantalla";
            this.btnMaximizarPantalla.Size = new System.Drawing.Size(34, 20);
            this.btnMaximizarPantalla.TabIndex = 2;
            this.btnMaximizarPantalla.UseVisualStyleBackColor = false;
            this.btnMaximizarPantalla.Click += new System.EventHandler(this.btnMaximizarPantalla_Click);
            // 
            // btnCerrarPantalla
            // 
            this.btnCerrarPantalla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarPantalla.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCerrarPantalla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrarPantalla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarPantalla.FlatAppearance.BorderSize = 0;
            this.btnCerrarPantalla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarPantalla.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrarPantalla.IconColor = System.Drawing.SystemColors.Control;
            this.btnCerrarPantalla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarPantalla.IconSize = 30;
            this.btnCerrarPantalla.Location = new System.Drawing.Point(728, 0);
            this.btnCerrarPantalla.Name = "btnCerrarPantalla";
            this.btnCerrarPantalla.Size = new System.Drawing.Size(34, 20);
            this.btnCerrarPantalla.TabIndex = 1;
            this.btnCerrarPantalla.UseVisualStyleBackColor = false;
            this.btnCerrarPantalla.Click += new System.EventHandler(this.btnCerrarPantalla_Click);
            // 
            // panelGeneral
            // 
            this.panelGeneral.AutoSize = true;
            this.panelGeneral.BackColor = System.Drawing.Color.Transparent;
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(172, 49);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(762, 393);
            this.panelGeneral.TabIndex = 2;
            // 
            // subMenu1
            // 
            this.subMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.subMenu1.IsMainMenu = false;
            this.subMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAltaPais,
            this.btnAltaProvincia,
            this.btnAltaCiudad,
            this.btnAltaBarrio,
            this.btnCodArea,
            this.btnTipoDocumento});
            this.subMenu1.MenuItemHeight = 35;
            this.subMenu1.MenuItemTextColor = System.Drawing.Color.IndianRed;
            this.subMenu1.Name = "subMenu1";
            this.subMenu1.PrimaryColor = System.Drawing.Color.Blue;
            this.subMenu1.Size = new System.Drawing.Size(188, 158);
            this.subMenu1.Opening += new System.ComponentModel.CancelEventHandler(this.subMenu1_Opening);
            // 
            // btnAltaPais
            // 
            this.btnAltaPais.Name = "btnAltaPais";
            this.btnAltaPais.Size = new System.Drawing.Size(187, 22);
            this.btnAltaPais.Text = "Alta Pais";
            this.btnAltaPais.Click += new System.EventHandler(this.btnAltaPais_Click);
            // 
            // btnAltaProvincia
            // 
            this.btnAltaProvincia.Name = "btnAltaProvincia";
            this.btnAltaProvincia.Size = new System.Drawing.Size(187, 22);
            this.btnAltaProvincia.Text = "Alta Provincia";
            this.btnAltaProvincia.Click += new System.EventHandler(this.btnAltaProvincia_Click);
            // 
            // btnAltaCiudad
            // 
            this.btnAltaCiudad.Name = "btnAltaCiudad";
            this.btnAltaCiudad.Size = new System.Drawing.Size(187, 22);
            this.btnAltaCiudad.Text = "Alta Ciudad";
            this.btnAltaCiudad.Click += new System.EventHandler(this.btnAltaCiudad_Click);
            // 
            // btnAltaBarrio
            // 
            this.btnAltaBarrio.Name = "btnAltaBarrio";
            this.btnAltaBarrio.Size = new System.Drawing.Size(187, 22);
            this.btnAltaBarrio.Text = "Alta Barrio";
            this.btnAltaBarrio.Click += new System.EventHandler(this.btnAltaBarrio_Click);
            // 
            // btnCodArea
            // 
            this.btnCodArea.Name = "btnCodArea";
            this.btnCodArea.Size = new System.Drawing.Size(187, 22);
            this.btnCodArea.Text = "Alta Codigo de Area";
            this.btnCodArea.Click += new System.EventHandler(this.btnCodArea_Click);
            // 
            // btnTipoDocumento
            // 
            this.btnTipoDocumento.Name = "btnTipoDocumento";
            this.btnTipoDocumento.Size = new System.Drawing.Size(187, 22);
            this.btnTipoDocumento.Text = "Alta Tipo Documento";
            this.btnTipoDocumento.Click += new System.EventHandler(this.btnTipoDocumento_Click);
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.IsMainMenu = false;
            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // rjDropdownMenu2
            // 
            this.rjDropdownMenu2.IsMainMenu = false;
            this.rjDropdownMenu2.MenuItemHeight = 25;
            this.rjDropdownMenu2.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu2.Name = "rjDropdownMenu2";
            this.rjDropdownMenu2.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu2.Size = new System.Drawing.Size(61, 4);
            // 
            // rjDropdownMenu3
            // 
            this.rjDropdownMenu3.IsMainMenu = false;
            this.rjDropdownMenu3.MenuItemHeight = 25;
            this.rjDropdownMenu3.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu3.Name = "rjDropdownMenu3";
            this.rjDropdownMenu3.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu3.Size = new System.Drawing.Size(61, 4);
            // 
            // rjDropdownMenu4
            // 
            this.rjDropdownMenu4.IsMainMenu = false;
            this.rjDropdownMenu4.MenuItemHeight = 25;
            this.rjDropdownMenu4.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu4.Name = "rjDropdownMenu4";
            this.rjDropdownMenu4.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu4.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 442);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.subMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private FontAwesome.Sharp.IconButton btnABM1;
        private FontAwesome.Sharp.IconButton btnABM3;
        private FontAwesome.Sharp.IconButton btnABM2;
        private FontAwesome.Sharp.IconButton btnMinimizarPantalla;
        private FontAwesome.Sharp.IconButton btnMaximizarPantalla;
        private FontAwesome.Sharp.IconButton btnCerrarPantalla;
        private System.Windows.Forms.Label lblDashboard;
        private FontAwesome.Sharp.IconButton btnLateralMenu;
        private RJCodeAdvance.RJControls.RJDropdownMenu subMenu1;
        private System.Windows.Forms.ToolStripMenuItem btnAltaPais;
        private System.Windows.Forms.ToolStripMenuItem btnAltaProvincia;
        private System.Windows.Forms.ToolStripMenuItem btnAltaCiudad;
        private RJCodeAdvance.RJControls.RJDropdownMenu rjDropdownMenu1;
        private RJCodeAdvance.RJControls.RJDropdownMenu rjDropdownMenu2;
        private RJCodeAdvance.RJControls.RJDropdownMenu rjDropdownMenu3;
        private RJCodeAdvance.RJControls.RJDropdownMenu rjDropdownMenu4;
        private System.Windows.Forms.ToolStripMenuItem btnAltaBarrio;
        private System.Windows.Forms.ToolStripMenuItem btnCodArea;
        private System.Windows.Forms.ToolStripMenuItem btnTipoDocumento;
        private System.Windows.Forms.Label txtLabelUsuario;
    }
}

