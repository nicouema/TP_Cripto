﻿using System;

namespace Criptomonedas
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnEjecutivoCuenta = new FontAwesome.Sharp.IconButton();
            this.btnCriptomonedas = new FontAwesome.Sharp.IconButton();
            this.btnDatosCliente = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLateralMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.txtLabelUsuario = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.btnMinimizarPantalla = new FontAwesome.Sharp.IconButton();
            this.btnMaximizarPantalla = new FontAwesome.Sharp.IconButton();
            this.btnCerrarPantalla = new FontAwesome.Sharp.IconButton();
            this.SM_ABM_DatosCliente = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.btnAltaPais = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAltaProvincia = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAltaCiudad = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAltaBarrio = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTipoDocumento = new System.Windows.Forms.ToolStripMenuItem();
            this.altaÁreaTelefónicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaTeléfonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SM_ABM_Criptomonedas = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.aBMMonederosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMCotizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SM_ABM_EjecutivoCuentas = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelCompraVenta = new System.Windows.Forms.Panel();
            this.btnVender = new FontAwesome.Sharp.IconButton();
            this.grillaCripto = new System.Windows.Forms.DataGridView();
            this.cripno_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCompra = new FontAwesome.Sharp.IconButton();
            this.btnInformes = new FontAwesome.Sharp.IconButton();
            this.SM_Informes = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.SM_ABM_DatosCliente.SuspendLayout();
            this.SM_ABM_Criptomonedas.SuspendLayout();
            this.SM_ABM_EjecutivoCuentas.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelCompraVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCripto)).BeginInit();
            this.SM_Informes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panelMenu.Controls.Add(this.btnInformes);
            this.panelMenu.Controls.Add(this.btnEjecutivoCuenta);
            this.panelMenu.Controls.Add(this.btnCriptomonedas);
            this.panelMenu.Controls.Add(this.btnDatosCliente);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(307, 886);
            this.panelMenu.TabIndex = 0;
            // 
            // btnEjecutivoCuenta
            // 
            this.btnEjecutivoCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjecutivoCuenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEjecutivoCuenta.FlatAppearance.BorderSize = 0;
            this.btnEjecutivoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjecutivoCuenta.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutivoCuenta.ForeColor = System.Drawing.Color.Black;
            this.btnEjecutivoCuenta.IconChar = FontAwesome.Sharp.IconChar.FunnelDollar;
            this.btnEjecutivoCuenta.IconColor = System.Drawing.Color.Black;
            this.btnEjecutivoCuenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEjecutivoCuenta.IconSize = 40;
            this.btnEjecutivoCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEjecutivoCuenta.Location = new System.Drawing.Point(0, 271);
            this.btnEjecutivoCuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEjecutivoCuenta.Name = "btnEjecutivoCuenta";
            this.btnEjecutivoCuenta.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnEjecutivoCuenta.Size = new System.Drawing.Size(307, 74);
            this.btnEjecutivoCuenta.TabIndex = 2;
            this.btnEjecutivoCuenta.Tag = "ABM Ejecutivo de Cuentas";
            this.btnEjecutivoCuenta.Text = "ABM Ejecutivos de Cuenta";
            this.btnEjecutivoCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEjecutivoCuenta.UseVisualStyleBackColor = true;
            this.btnEjecutivoCuenta.Click += new System.EventHandler(this.btnEjecutivoCuenta_Click);
            // 
            // btnCriptomonedas
            // 
            this.btnCriptomonedas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriptomonedas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCriptomonedas.FlatAppearance.BorderSize = 0;
            this.btnCriptomonedas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriptomonedas.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriptomonedas.ForeColor = System.Drawing.Color.Black;
            this.btnCriptomonedas.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.btnCriptomonedas.IconColor = System.Drawing.Color.Black;
            this.btnCriptomonedas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCriptomonedas.IconSize = 40;
            this.btnCriptomonedas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriptomonedas.Location = new System.Drawing.Point(0, 197);
            this.btnCriptomonedas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCriptomonedas.Name = "btnCriptomonedas";
            this.btnCriptomonedas.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnCriptomonedas.Size = new System.Drawing.Size(307, 74);
            this.btnCriptomonedas.TabIndex = 1;
            this.btnCriptomonedas.Tag = "ABM Criptomonedas";
            this.btnCriptomonedas.Text = "ABM Criptomonedas";
            this.btnCriptomonedas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCriptomonedas.UseVisualStyleBackColor = true;
            this.btnCriptomonedas.Click += new System.EventHandler(this.btnABM2_Click);
            // 
            // btnDatosCliente
            // 
            this.btnDatosCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatosCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatosCliente.FlatAppearance.BorderSize = 0;
            this.btnDatosCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatosCliente.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatosCliente.ForeColor = System.Drawing.Color.Black;
            this.btnDatosCliente.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnDatosCliente.IconColor = System.Drawing.Color.Black;
            this.btnDatosCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDatosCliente.IconSize = 40;
            this.btnDatosCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatosCliente.Location = new System.Drawing.Point(0, 123);
            this.btnDatosCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDatosCliente.Name = "btnDatosCliente";
            this.btnDatosCliente.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnDatosCliente.Size = new System.Drawing.Size(307, 74);
            this.btnDatosCliente.TabIndex = 0;
            this.btnDatosCliente.Tag = "ABM Datos de Cliente";
            this.btnDatosCliente.Text = "ABM Datos de Cliente";
            this.btnDatosCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatosCliente.UseVisualStyleBackColor = true;
            this.btnDatosCliente.Click += new System.EventHandler(this.btnABM1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnLateralMenu);
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 123);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(307, 63);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1515, 823);
            this.panel2.TabIndex = 3;
            // 
            // btnLateralMenu
            // 
            this.btnLateralMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnLateralMenu.Location = new System.Drawing.Point(243, 4);
            this.btnLateralMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLateralMenu.Name = "btnLateralMenu";
            this.btnLateralMenu.Size = new System.Drawing.Size(60, 60);
            this.btnLateralMenu.TabIndex = 1;
            this.btnLateralMenu.UseVisualStyleBackColor = false;
            this.btnLateralMenu.Click += new System.EventHandler(this.btnLateralMenu_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(157, 60);
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
            this.panelTitulo.Location = new System.Drawing.Point(307, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1514, 60);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown_1);
            // 
            // txtLabelUsuario
            // 
            this.txtLabelUsuario.AutoSize = true;
            this.txtLabelUsuario.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.txtLabelUsuario.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtLabelUsuario.Location = new System.Drawing.Point(576, 28);
            this.txtLabelUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtLabelUsuario.Name = "txtLabelUsuario";
            this.txtLabelUsuario.Size = new System.Drawing.Size(95, 29);
            this.txtLabelUsuario.TabIndex = 0;
            this.txtLabelUsuario.Text = "label1";
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboard.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.lblDashboard.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblDashboard.Location = new System.Drawing.Point(29, 18);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(193, 31);
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
            this.btnMinimizarPantalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarPantalla.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizarPantalla.IconColor = System.Drawing.SystemColors.Control;
            this.btnMinimizarPantalla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizarPantalla.IconSize = 20;
            this.btnMinimizarPantalla.Location = new System.Drawing.Point(1383, 0);
            this.btnMinimizarPantalla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimizarPantalla.Name = "btnMinimizarPantalla";
            this.btnMinimizarPantalla.Size = new System.Drawing.Size(45, 25);
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
            this.btnMaximizarPantalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizarPantalla.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizarPantalla.IconColor = System.Drawing.SystemColors.Control;
            this.btnMaximizarPantalla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizarPantalla.IconSize = 20;
            this.btnMaximizarPantalla.Location = new System.Drawing.Point(1427, 0);
            this.btnMaximizarPantalla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaximizarPantalla.Name = "btnMaximizarPantalla";
            this.btnMaximizarPantalla.Size = new System.Drawing.Size(45, 25);
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
            this.btnCerrarPantalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPantalla.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrarPantalla.IconColor = System.Drawing.SystemColors.Control;
            this.btnCerrarPantalla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarPantalla.IconSize = 30;
            this.btnCerrarPantalla.Location = new System.Drawing.Point(1468, 0);
            this.btnCerrarPantalla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrarPantalla.Name = "btnCerrarPantalla";
            this.btnCerrarPantalla.Size = new System.Drawing.Size(45, 25);
            this.btnCerrarPantalla.TabIndex = 1;
            this.btnCerrarPantalla.UseVisualStyleBackColor = false;
            this.btnCerrarPantalla.Click += new System.EventHandler(this.btnCerrarPantalla_Click);
            // 
            // SM_ABM_DatosCliente
            // 
            this.SM_ABM_DatosCliente.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.SM_ABM_DatosCliente.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SM_ABM_DatosCliente.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SM_ABM_DatosCliente.IsMainMenu = false;
            this.SM_ABM_DatosCliente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAltaPais,
            this.btnAltaProvincia,
            this.btnAltaCiudad,
            this.btnAltaBarrio,
            this.btnTipoDocumento,
            this.altaÁreaTelefónicaToolStripMenuItem,
            this.altaTeléfonoToolStripMenuItem,
            this.modificarClienteToolStripMenuItem});
            this.SM_ABM_DatosCliente.MenuItemHeight = 35;
            this.SM_ABM_DatosCliente.MenuItemTextColor = System.Drawing.Color.Black;
            this.SM_ABM_DatosCliente.Name = "subMenu1";
            this.SM_ABM_DatosCliente.PrimaryColor = System.Drawing.Color.DarkViolet;
            this.SM_ABM_DatosCliente.Size = new System.Drawing.Size(247, 180);
            this.SM_ABM_DatosCliente.Opening += new System.ComponentModel.CancelEventHandler(this.SM_ABM_DatosCliente_Opening);
            // 
            // btnAltaPais
            // 
            this.btnAltaPais.Name = "btnAltaPais";
            this.btnAltaPais.Size = new System.Drawing.Size(246, 22);
            this.btnAltaPais.Text = "Alta Pais";
            this.btnAltaPais.Click += new System.EventHandler(this.btnAltaPais_Click);
            // 
            // btnAltaProvincia
            // 
            this.btnAltaProvincia.Name = "btnAltaProvincia";
            this.btnAltaProvincia.Size = new System.Drawing.Size(246, 22);
            this.btnAltaProvincia.Text = "Alta Provincia";
            this.btnAltaProvincia.Click += new System.EventHandler(this.btnAltaProvincia_Click);
            // 
            // btnAltaCiudad
            // 
            this.btnAltaCiudad.Name = "btnAltaCiudad";
            this.btnAltaCiudad.Size = new System.Drawing.Size(246, 22);
            this.btnAltaCiudad.Text = "Alta Ciudad";
            this.btnAltaCiudad.Click += new System.EventHandler(this.btnAltaCiudad_Click);
            // 
            // btnAltaBarrio
            // 
            this.btnAltaBarrio.Name = "btnAltaBarrio";
            this.btnAltaBarrio.Size = new System.Drawing.Size(246, 22);
            this.btnAltaBarrio.Text = "Alta Barrio";
            this.btnAltaBarrio.Click += new System.EventHandler(this.btnAltaBarrio_Click);
            // 
            // btnTipoDocumento
            // 
            this.btnTipoDocumento.Name = "btnTipoDocumento";
            this.btnTipoDocumento.Size = new System.Drawing.Size(246, 22);
            this.btnTipoDocumento.Text = "Alta Tipo Documento";
            this.btnTipoDocumento.Click += new System.EventHandler(this.btnTipoDocumento_Click);
            // 
            // altaÁreaTelefónicaToolStripMenuItem
            // 
            this.altaÁreaTelefónicaToolStripMenuItem.Name = "altaÁreaTelefónicaToolStripMenuItem";
            this.altaÁreaTelefónicaToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.altaÁreaTelefónicaToolStripMenuItem.Text = "Alta Área Telefónica";
            this.altaÁreaTelefónicaToolStripMenuItem.Click += new System.EventHandler(this.altaÁreaTelefónicaToolStripMenuItem_Click);
            // 
            // altaTeléfonoToolStripMenuItem
            // 
            this.altaTeléfonoToolStripMenuItem.Name = "altaTeléfonoToolStripMenuItem";
            this.altaTeléfonoToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.altaTeléfonoToolStripMenuItem.Text = "Alta Teléfono";
            this.altaTeléfonoToolStripMenuItem.Click += new System.EventHandler(this.altaTeléfonoToolStripMenuItem_Click);
            // 
            // modificarClienteToolStripMenuItem
            // 
            this.modificarClienteToolStripMenuItem.Name = "modificarClienteToolStripMenuItem";
            this.modificarClienteToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.modificarClienteToolStripMenuItem.Text = "ABM Cliente";
            this.modificarClienteToolStripMenuItem.Click += new System.EventHandler(this.modificarClienteToolStripMenuItem_Click);
            // 
            // SM_ABM_Criptomonedas
            // 
            this.SM_ABM_Criptomonedas.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.SM_ABM_Criptomonedas.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SM_ABM_Criptomonedas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SM_ABM_Criptomonedas.IsMainMenu = false;
            this.SM_ABM_Criptomonedas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMMonederosToolStripMenuItem,
            this.aBMToolStripMenuItem,
            this.aBMToolStripMenuItem1,
            this.aBMCotizacionesToolStripMenuItem});
            this.SM_ABM_Criptomonedas.MenuItemHeight = 25;
            this.SM_ABM_Criptomonedas.MenuItemTextColor = System.Drawing.Color.Black;
            this.SM_ABM_Criptomonedas.Name = "rjDropdownMenu1";
            this.SM_ABM_Criptomonedas.PrimaryColor = System.Drawing.Color.DarkViolet;
            this.SM_ABM_Criptomonedas.Size = new System.Drawing.Size(279, 92);
            // 
            // aBMMonederosToolStripMenuItem
            // 
            this.aBMMonederosToolStripMenuItem.Name = "aBMMonederosToolStripMenuItem";
            this.aBMMonederosToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.aBMMonederosToolStripMenuItem.Text = "ABM Monederos";
            this.aBMMonederosToolStripMenuItem.Click += new System.EventHandler(this.aBMMonederosToolStripMenuItem_Click);
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.aBMToolStripMenuItem.Text = "ABM Criptomonedas";
            this.aBMToolStripMenuItem.Click += new System.EventHandler(this.aBMToolStripMenuItem_Click);
            // 
            // aBMToolStripMenuItem1
            // 
            this.aBMToolStripMenuItem1.Name = "aBMToolStripMenuItem1";
            this.aBMToolStripMenuItem1.Size = new System.Drawing.Size(278, 22);
            this.aBMToolStripMenuItem1.Text = "ABM Tipo de Transacción";
            this.aBMToolStripMenuItem1.Click += new System.EventHandler(this.aBMToolStripMenuItem1_Click);
            // 
            // aBMCotizacionesToolStripMenuItem
            // 
            this.aBMCotizacionesToolStripMenuItem.Name = "aBMCotizacionesToolStripMenuItem";
            this.aBMCotizacionesToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.aBMCotizacionesToolStripMenuItem.Text = "ABM Cotizaciones";
            this.aBMCotizacionesToolStripMenuItem.Click += new System.EventHandler(this.aBMCotizacionesToolStripMenuItem_Click);
            // 
            // SM_ABM_EjecutivoCuentas
            // 
            this.SM_ABM_EjecutivoCuentas.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.SM_ABM_EjecutivoCuentas.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SM_ABM_EjecutivoCuentas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SM_ABM_EjecutivoCuentas.IsMainMenu = false;
            this.SM_ABM_EjecutivoCuentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.SM_ABM_EjecutivoCuentas.MenuItemHeight = 25;
            this.SM_ABM_EjecutivoCuentas.MenuItemTextColor = System.Drawing.Color.Black;
            this.SM_ABM_EjecutivoCuentas.Name = "rjDropdownMenu1";
            this.SM_ABM_EjecutivoCuentas.PrimaryColor = System.Drawing.Color.DarkViolet;
            this.SM_ABM_EjecutivoCuentas.Size = new System.Drawing.Size(291, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(290, 22);
            this.toolStripMenuItem1.Text = "ABM Empresa";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(290, 22);
            this.toolStripMenuItem2.Text = "ABM Ejecutivo de Cuentas";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.panelCompraVenta);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel3.Location = new System.Drawing.Point(307, 60);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1514, 826);
            this.panel3.TabIndex = 9;
            // 
            // panelCompraVenta
            // 
            this.panelCompraVenta.Controls.Add(this.btnVender);
            this.panelCompraVenta.Controls.Add(this.grillaCripto);
            this.panelCompraVenta.Controls.Add(this.btnCompra);
            this.panelCompraVenta.Location = new System.Drawing.Point(8, 7);
            this.panelCompraVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCompraVenta.Name = "panelCompraVenta";
            this.panelCompraVenta.Size = new System.Drawing.Size(539, 661);
            this.panelCompraVenta.TabIndex = 9;
            this.panelCompraVenta.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCompraVenta_Paint);
            // 
            // btnVender
            // 
            this.btnVender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVender.BackColor = System.Drawing.Color.Red;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVender.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.btnVender.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVender.IconColor = System.Drawing.Color.Black;
            this.btnVender.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVender.Location = new System.Drawing.Point(193, 4);
            this.btnVender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(176, 70);
            this.btnVender.TabIndex = 5;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // grillaCripto
            // 
            this.grillaCripto.AllowUserToAddRows = false;
            this.grillaCripto.AllowUserToDeleteRows = false;
            this.grillaCripto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grillaCripto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grillaCripto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCripto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cripno_nombre,
            this.precio});
            this.grillaCripto.Location = new System.Drawing.Point(9, 81);
            this.grillaCripto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grillaCripto.Name = "grillaCripto";
            this.grillaCripto.ReadOnly = true;
            this.grillaCripto.RowHeadersWidth = 51;
            this.grillaCripto.Size = new System.Drawing.Size(360, 550);
            this.grillaCripto.TabIndex = 6;
            // 
            // cripno_nombre
            // 
            this.cripno_nombre.DataPropertyName = "nombre";
            this.cripno_nombre.HeaderText = "Criptomoneda";
            this.cripno_nombre.MinimumWidth = 6;
            this.cripno_nombre.Name = "cripno_nombre";
            this.cripno_nombre.ReadOnly = true;
            this.cripno_nombre.Width = 125;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "valor";
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 125;
            // 
            // btnCompra
            // 
            this.btnCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompra.BackColor = System.Drawing.Color.Lime;
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompra.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.btnCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCompra.IconColor = System.Drawing.Color.Black;
            this.btnCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompra.Location = new System.Drawing.Point(9, 4);
            this.btnCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(176, 70);
            this.btnCompra.TabIndex = 4;
            this.btnCompra.Text = "Comprar";
            this.btnCompra.UseVisualStyleBackColor = false;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformes.FlatAppearance.BorderSize = 0;
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.ForeColor = System.Drawing.Color.Black;
            this.btnInformes.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnInformes.IconColor = System.Drawing.Color.Black;
            this.btnInformes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInformes.IconSize = 40;
            this.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Location = new System.Drawing.Point(0, 345);
            this.btnInformes.Margin = new System.Windows.Forms.Padding(4);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnInformes.Size = new System.Drawing.Size(307, 74);
            this.btnInformes.TabIndex = 3;
            this.btnInformes.Tag = "Informes";
            this.btnInformes.Text = "         Informes";
            this.btnInformes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // SM_Informes
            // 
            this.SM_Informes.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.SM_Informes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SM_Informes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SM_Informes.IsMainMenu = false;
            this.SM_Informes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.SM_Informes.MenuItemHeight = 25;
            this.SM_Informes.MenuItemTextColor = System.Drawing.Color.Black;
            this.SM_Informes.Name = "rjDropdownMenu1";
            this.SM_Informes.PrimaryColor = System.Drawing.Color.DarkViolet;
            this.SM_Informes.Size = new System.Drawing.Size(232, 26);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItem3.Text = "Listado de Clientes";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1821, 886);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.SM_ABM_DatosCliente.ResumeLayout(false);
            this.SM_ABM_Criptomonedas.ResumeLayout(false);
            this.SM_ABM_EjecutivoCuentas.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelCompraVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grillaCripto)).EndInit();
            this.SM_Informes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private FontAwesome.Sharp.IconButton btnDatosCliente;
        private FontAwesome.Sharp.IconButton btnEjecutivoCuenta;
        private FontAwesome.Sharp.IconButton btnCriptomonedas;
        private FontAwesome.Sharp.IconButton btnMinimizarPantalla;
        private System.Windows.Forms.Label lblDashboard;
        private FontAwesome.Sharp.IconButton btnLateralMenu;
        private RJCodeAdvance.RJControls.RJDropdownMenu SM_ABM_DatosCliente;
        private System.Windows.Forms.ToolStripMenuItem btnAltaPais;
        private System.Windows.Forms.ToolStripMenuItem btnAltaProvincia;
        private System.Windows.Forms.ToolStripMenuItem btnAltaCiudad;
        private RJCodeAdvance.RJControls.RJDropdownMenu SM_ABM_Criptomonedas;
        private System.Windows.Forms.ToolStripMenuItem btnAltaBarrio;
        private System.Windows.Forms.ToolStripMenuItem btnTipoDocumento;
        private System.Windows.Forms.Label txtLabelUsuario;
        private System.Windows.Forms.ToolStripMenuItem altaÁreaTelefónicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaTeléfonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMMonederosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aBMCotizacionesToolStripMenuItem;
        private RJCodeAdvance.RJControls.RJDropdownMenu SM_ABM_EjecutivoCuentas;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modificarClienteToolStripMenuItem;
        private FontAwesome.Sharp.IconButton btnMaximizarPantalla;
        private FontAwesome.Sharp.IconButton btnCerrarPantalla;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelCompraVenta;
        private FontAwesome.Sharp.IconButton btnVender;
        private System.Windows.Forms.DataGridView grillaCripto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cripno_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private FontAwesome.Sharp.IconButton btnCompra;
        private FontAwesome.Sharp.IconButton btnInformes;
        private RJCodeAdvance.RJControls.RJDropdownMenu SM_Informes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

