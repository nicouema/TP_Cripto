﻿namespace Criptomonedas.Formularios_Ventanas_.ABM_s.Ejecutivo_de_Cuentas
{
    partial class ABM_EjecutivoDeCuentas
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
            this.grillaClientes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCrear = new RJCodeAdvance.RJControls.RJButton();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelNombreEmpresa = new System.Windows.Forms.Label();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            this.lblModificar = new System.Windows.Forms.Label();
            this.labelNumeroDocumento = new System.Windows.Forms.Label();
            this.comboTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelApellido = new System.Windows.Forms.Label();
            this.txtRegApellido = new System.Windows.Forms.TextBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnModificar = new RJCodeAdvance.RJControls.RJButton();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtRegNombre = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimizarPantallaABMCLiente = new FontAwesome.Sharp.IconButton();
            this.btnCerrarPantallaABMCliente = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaClientes
            // 
            this.grillaClientes.AllowUserToAddRows = false;
            this.grillaClientes.AllowUserToDeleteRows = false;
            this.grillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Email,
            this.fechaAlta,
            this.codBarrio,
            this.codUsuario});
            this.grillaClientes.Location = new System.Drawing.Point(372, 41);
            this.grillaClientes.Name = "grillaClientes";
            this.grillaClientes.ReadOnly = true;
            this.grillaClientes.Size = new System.Drawing.Size(855, 462);
            this.grillaClientes.TabIndex = 69;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "tipo_doc";
            this.Email.HeaderText = "Tipo de Documento";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // fechaAlta
            // 
            this.fechaAlta.DataPropertyName = "nro_doc";
            this.fechaAlta.HeaderText = "Numero de Documento";
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.ReadOnly = true;
            // 
            // codBarrio
            // 
            this.codBarrio.DataPropertyName = "legajo";
            this.codBarrio.HeaderText = "Legajo";
            this.codBarrio.Name = "codBarrio";
            this.codBarrio.ReadOnly = true;
            // 
            // codUsuario
            // 
            this.codUsuario.DataPropertyName = "id_empresa";
            this.codUsuario.HeaderText = "Codigo de Empresa";
            this.codUsuario.Name = "codUsuario";
            this.codUsuario.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCrear);
            this.panel1.Controls.Add(this.txtDocumento);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.labelNombreEmpresa);
            this.panel1.Controls.Add(this.txtNombreEmpresa);
            this.panel1.Controls.Add(this.iconPictureBox6);
            this.panel1.Controls.Add(this.lblModificar);
            this.panel1.Controls.Add(this.labelNumeroDocumento);
            this.panel1.Controls.Add(this.comboTipoDoc);
            this.panel1.Controls.Add(this.lblTipoDocumento);
            this.panel1.Controls.Add(this.iconPictureBox5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.lblLegajo);
            this.panel1.Controls.Add(this.txtLegajo);
            this.panel1.Controls.Add(this.iconPictureBox4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.labelApellido);
            this.panel1.Controls.Add(this.txtRegApellido);
            this.panel1.Controls.Add(this.iconPictureBox3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.lblNombreCliente);
            this.panel1.Controls.Add(this.txtRegNombre);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(23, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 504);
            this.panel1.TabIndex = 68;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnCrear.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.btnCrear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCrear.BorderRadius = 0;
            this.btnCrear.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(17, 316);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(177, 27);
            this.btnCrear.TabIndex = 66;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.TextColor = System.Drawing.Color.White;
            this.btnCrear.UseVisualStyleBackColor = false;
            // 
            // txtDocumento
            // 
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDocumento.Location = new System.Drawing.Point(42, 239);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumento.Multiline = true;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(288, 20);
            this.txtDocumento.TabIndex = 65;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkViolet;
            this.panel7.Location = new System.Drawing.Point(18, 311);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(312, 1);
            this.panel7.TabIndex = 62;
            // 
            // labelNombreEmpresa
            // 
            this.labelNombreEmpresa.AutoSize = true;
            this.labelNombreEmpresa.BackColor = System.Drawing.SystemColors.Control;
            this.labelNombreEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreEmpresa.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelNombreEmpresa.Location = new System.Drawing.Point(39, 269);
            this.labelNombreEmpresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreEmpresa.Name = "labelNombreEmpresa";
            this.labelNombreEmpresa.Size = new System.Drawing.Size(139, 15);
            this.labelNombreEmpresa.TabIndex = 61;
            this.labelNombreEmpresa.Text = "Nombre de Empresa";
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpresa.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNombreEmpresa.Location = new System.Drawing.Point(42, 288);
            this.txtNombreEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreEmpresa.Multiline = true;
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(288, 20);
            this.txtNombreEmpresa.TabIndex = 7;
            // 
            // iconPictureBox6
            // 
            this.iconPictureBox6.BackColor = System.Drawing.Color.White;
            this.iconPictureBox6.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconPictureBox6.IconColor = System.Drawing.Color.MediumTurquoise;
            this.iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox6.IconSize = 19;
            this.iconPictureBox6.Location = new System.Drawing.Point(18, 286);
            this.iconPictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox6.Name = "iconPictureBox6";
            this.iconPictureBox6.Size = new System.Drawing.Size(19, 20);
            this.iconPictureBox6.TabIndex = 59;
            this.iconPictureBox6.TabStop = false;
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblModificar.Location = new System.Drawing.Point(12, 0);
            this.lblModificar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(410, 36);
            this.lblModificar.TabIndex = 16;
            this.lblModificar.Text = "ABM Ejecutivo de Cuentas";
            // 
            // labelNumeroDocumento
            // 
            this.labelNumeroDocumento.AutoSize = true;
            this.labelNumeroDocumento.BackColor = System.Drawing.SystemColors.Control;
            this.labelNumeroDocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroDocumento.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelNumeroDocumento.Location = new System.Drawing.Point(39, 222);
            this.labelNumeroDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumeroDocumento.Name = "labelNumeroDocumento";
            this.labelNumeroDocumento.Size = new System.Drawing.Size(155, 15);
            this.labelNumeroDocumento.TabIndex = 54;
            this.labelNumeroDocumento.Text = "Numero de Documento";
            // 
            // comboTipoDoc
            // 
            this.comboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboTipoDoc.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.comboTipoDoc.FormattingEnabled = true;
            this.comboTipoDoc.Location = new System.Drawing.Point(42, 195);
            this.comboTipoDoc.Name = "comboTipoDoc";
            this.comboTipoDoc.Size = new System.Drawing.Size(288, 24);
            this.comboTipoDoc.TabIndex = 4;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.BackColor = System.Drawing.SystemColors.Control;
            this.lblTipoDocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumento.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTipoDocumento.Location = new System.Drawing.Point(39, 178);
            this.lblTipoDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(132, 15);
            this.lblTipoDocumento.TabIndex = 51;
            this.lblTipoDocumento.Text = "Tipo de Documento";
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.White;
            this.iconPictureBox5.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.IdCardAlt;
            this.iconPictureBox5.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 19;
            this.iconPictureBox5.Location = new System.Drawing.Point(18, 199);
            this.iconPictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(19, 20);
            this.iconPictureBox5.TabIndex = 48;
            this.iconPictureBox5.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkViolet;
            this.panel6.Location = new System.Drawing.Point(18, 265);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(312, 1);
            this.panel6.TabIndex = 49;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.BackColor = System.Drawing.SystemColors.Control;
            this.lblLegajo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblLegajo.Location = new System.Drawing.Point(39, 134);
            this.lblLegajo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(51, 15);
            this.lblLegajo.TabIndex = 47;
            this.lblLegajo.Text = "Legajo";
            // 
            // txtLegajo
            // 
            this.txtLegajo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLegajo.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtLegajo.Location = new System.Drawing.Point(42, 151);
            this.txtLegajo.Margin = new System.Windows.Forms.Padding(2);
            this.txtLegajo.Multiline = true;
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(288, 20);
            this.txtLegajo.TabIndex = 3;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.White;
            this.iconPictureBox4.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.iconPictureBox4.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 19;
            this.iconPictureBox4.Location = new System.Drawing.Point(18, 151);
            this.iconPictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(19, 20);
            this.iconPictureBox4.TabIndex = 44;
            this.iconPictureBox4.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkViolet;
            this.panel5.Location = new System.Drawing.Point(18, 176);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(312, 1);
            this.panel5.TabIndex = 45;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.BackColor = System.Drawing.SystemColors.Control;
            this.labelApellido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelApellido.Location = new System.Drawing.Point(39, 90);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(59, 15);
            this.labelApellido.TabIndex = 43;
            this.labelApellido.Text = "Apellido";
            // 
            // txtRegApellido
            // 
            this.txtRegApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegApellido.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtRegApellido.Location = new System.Drawing.Point(42, 107);
            this.txtRegApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegApellido.Multiline = true;
            this.txtRegApellido.Name = "txtRegApellido";
            this.txtRegApellido.Size = new System.Drawing.Size(288, 20);
            this.txtRegApellido.TabIndex = 2;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.White;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox3.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 19;
            this.iconPictureBox3.Location = new System.Drawing.Point(18, 107);
            this.iconPictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(19, 20);
            this.iconPictureBox3.TabIndex = 40;
            this.iconPictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkViolet;
            this.panel4.Location = new System.Drawing.Point(18, 132);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(312, 1);
            this.panel4.TabIndex = 41;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnModificar.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.btnModificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModificar.BorderRadius = 0;
            this.btnModificar.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(198, 316);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(132, 27);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.SystemColors.Control;
            this.lblNombreCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblNombreCliente.Location = new System.Drawing.Point(39, 45);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(58, 15);
            this.lblNombreCliente.TabIndex = 36;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // txtRegNombre
            // 
            this.txtRegNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegNombre.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtRegNombre.Location = new System.Drawing.Point(42, 62);
            this.txtRegNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegNombre.Multiline = true;
            this.txtRegNombre.Name = "txtRegNombre";
            this.txtRegNombre.Size = new System.Drawing.Size(288, 20);
            this.txtRegNombre.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 19;
            this.iconPictureBox1.Location = new System.Drawing.Point(18, 62);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(19, 20);
            this.iconPictureBox1.TabIndex = 31;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkViolet;
            this.panel2.Location = new System.Drawing.Point(18, 87);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 1);
            this.panel2.TabIndex = 32;
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
            this.btnMinimizarPantallaABMCLiente.Location = new System.Drawing.Point(1171, 0);
            this.btnMinimizarPantallaABMCLiente.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizarPantallaABMCLiente.Name = "btnMinimizarPantallaABMCLiente";
            this.btnMinimizarPantallaABMCLiente.Size = new System.Drawing.Size(34, 20);
            this.btnMinimizarPantallaABMCLiente.TabIndex = 67;
            this.btnMinimizarPantallaABMCLiente.UseVisualStyleBackColor = false;
            this.btnMinimizarPantallaABMCLiente.Click += new System.EventHandler(this.btnMinimizarPantallaABMCLiente_Click);
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
            this.btnCerrarPantallaABMCliente.Location = new System.Drawing.Point(1205, 0);
            this.btnCerrarPantallaABMCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarPantallaABMCliente.Name = "btnCerrarPantallaABMCliente";
            this.btnCerrarPantallaABMCliente.Size = new System.Drawing.Size(34, 20);
            this.btnCerrarPantallaABMCliente.TabIndex = 66;
            this.btnCerrarPantallaABMCliente.UseVisualStyleBackColor = false;
            this.btnCerrarPantallaABMCliente.Click += new System.EventHandler(this.btnCerrarPantallaABMCliente_Click);
            // 
            // ABM_EjecutivoDeCUentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 534);
            this.Controls.Add(this.grillaClientes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMinimizarPantallaABMCLiente);
            this.Controls.Add(this.btnCerrarPantallaABMCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ABM_EjecutivoDeCUentas";
            this.Text = "ABM_EjecutivoDeCUentas";
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn codUsuario;
        private System.Windows.Forms.Panel panel1;
        private RJCodeAdvance.RJControls.RJButton btnCrear;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labelNombreEmpresa;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Label labelNumeroDocumento;
        private System.Windows.Forms.ComboBox comboTipoDoc;
        private System.Windows.Forms.Label lblTipoDocumento;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtLegajo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox txtRegApellido;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Panel panel4;
        private RJCodeAdvance.RJControls.RJButton btnModificar;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtRegNombre;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnMinimizarPantallaABMCLiente;
        private FontAwesome.Sharp.IconButton btnCerrarPantallaABMCliente;
    }
}