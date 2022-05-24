﻿namespace Criptomonedas
{
    partial class ABM_Criptomoneda
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
            this.lblABM_Criptomoneda = new System.Windows.Forms.Label();
            this.panelCriptos = new System.Windows.Forms.Panel();
            this.btnCargar = new RJCodeAdvance.RJControls.RJButton();
            this.lblLimpiarCampos = new System.Windows.Forms.Label();
            this.btnActualizar = new RJCodeAdvance.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombreCripto = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.lblSiglaCripto = new System.Windows.Forms.Label();
            this.lblNombreCripto = new System.Windows.Forms.Label();
            this.grdCriptos = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new RJCodeAdvance.RJControls.RJButton();
            this.btnMinimizarPantallaReg = new FontAwesome.Sharp.IconButton();
            this.btnCerrarPantallaReg = new FontAwesome.Sharp.IconButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCriptos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCriptos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblABM_Criptomoneda
            // 
            this.lblABM_Criptomoneda.AutoSize = true;
            this.lblABM_Criptomoneda.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblABM_Criptomoneda.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABM_Criptomoneda.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblABM_Criptomoneda.Location = new System.Drawing.Point(11, 9);
            this.lblABM_Criptomoneda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblABM_Criptomoneda.Name = "lblABM_Criptomoneda";
            this.lblABM_Criptomoneda.Size = new System.Drawing.Size(309, 36);
            this.lblABM_Criptomoneda.TabIndex = 25;
            this.lblABM_Criptomoneda.Text = "ABM Criptomoneda";
            // 
            // panelCriptos
            // 
            this.panelCriptos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCriptos.Controls.Add(this.btnBorrar);
            this.panelCriptos.Controls.Add(this.btnCargar);
            this.panelCriptos.Controls.Add(this.lblLimpiarCampos);
            this.panelCriptos.Controls.Add(this.btnActualizar);
            this.panelCriptos.Controls.Add(this.panel1);
            this.panelCriptos.Controls.Add(this.txtNombreCripto);
            this.panelCriptos.Controls.Add(this.panel3);
            this.panelCriptos.Controls.Add(this.txtSigla);
            this.panelCriptos.Controls.Add(this.lblSiglaCripto);
            this.panelCriptos.Controls.Add(this.lblNombreCripto);
            this.panelCriptos.Location = new System.Drawing.Point(11, 64);
            this.panelCriptos.Margin = new System.Windows.Forms.Padding(2);
            this.panelCriptos.Name = "panelCriptos";
            this.panelCriptos.Size = new System.Drawing.Size(221, 262);
            this.panelCriptos.TabIndex = 45;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnCargar.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.btnCargar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCargar.BorderRadius = 0;
            this.btnCargar.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(112, 220);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(91, 27);
            this.btnCargar.TabIndex = 34;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.TextColor = System.Drawing.Color.White;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblLimpiarCampos
            // 
            this.lblLimpiarCampos.AutoSize = true;
            this.lblLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimpiarCampos.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblLimpiarCampos.Location = new System.Drawing.Point(91, 123);
            this.lblLimpiarCampos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLimpiarCampos.Name = "lblLimpiarCampos";
            this.lblLimpiarCampos.Size = new System.Drawing.Size(112, 15);
            this.lblLimpiarCampos.TabIndex = 44;
            this.lblLimpiarCampos.Text = "Limpiar Campos";
            this.lblLimpiarCampos.Click += new System.EventHandler(this.lblLimpiarCampos_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnActualizar.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.btnActualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActualizar.BorderRadius = 0;
            this.btnActualizar.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(17, 220);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(91, 27);
            this.btnActualizar.TabIndex = 27;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.TextColor = System.Drawing.Color.White;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Location = new System.Drawing.Point(17, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 1);
            this.panel1.TabIndex = 43;
            // 
            // txtNombreCripto
            // 
            this.txtNombreCripto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCripto.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNombreCripto.Location = new System.Drawing.Point(17, 35);
            this.txtNombreCripto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCripto.Multiline = true;
            this.txtNombreCripto.Name = "txtNombreCripto";
            this.txtNombreCripto.Size = new System.Drawing.Size(186, 20);
            this.txtNombreCripto.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel3.Location = new System.Drawing.Point(18, 106);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 1);
            this.panel3.TabIndex = 42;
            // 
            // txtSigla
            // 
            this.txtSigla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigla.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSigla.Location = new System.Drawing.Point(18, 87);
            this.txtSigla.Margin = new System.Windows.Forms.Padding(2);
            this.txtSigla.MaxLength = 4;
            this.txtSigla.Multiline = true;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(185, 20);
            this.txtSigla.TabIndex = 39;
            // 
            // lblSiglaCripto
            // 
            this.lblSiglaCripto.AutoSize = true;
            this.lblSiglaCripto.BackColor = System.Drawing.SystemColors.Control;
            this.lblSiglaCripto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblSiglaCripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiglaCripto.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblSiglaCripto.Location = new System.Drawing.Point(15, 68);
            this.lblSiglaCripto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSiglaCripto.Name = "lblSiglaCripto";
            this.lblSiglaCripto.Size = new System.Drawing.Size(40, 15);
            this.lblSiglaCripto.TabIndex = 41;
            this.lblSiglaCripto.Text = "Sigla";
            // 
            // lblNombreCripto
            // 
            this.lblNombreCripto.AutoSize = true;
            this.lblNombreCripto.BackColor = System.Drawing.SystemColors.Control;
            this.lblNombreCripto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblNombreCripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCripto.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblNombreCripto.Location = new System.Drawing.Point(15, 17);
            this.lblNombreCripto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreCripto.Name = "lblNombreCripto";
            this.lblNombreCripto.Size = new System.Drawing.Size(152, 15);
            this.lblNombreCripto.TabIndex = 40;
            this.lblNombreCripto.Text = "Nombre Criptomoneda";
            // 
            // grdCriptos
            // 
            this.grdCriptos.AllowUserToAddRows = false;
            this.grdCriptos.AllowUserToDeleteRows = false;
            this.grdCriptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCriptos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Sigla,
            this.Nombre});
            this.grdCriptos.Location = new System.Drawing.Point(243, 64);
            this.grdCriptos.Name = "grdCriptos";
            this.grdCriptos.ReadOnly = true;
            this.grdCriptos.Size = new System.Drawing.Size(383, 262);
            this.grdCriptos.TabIndex = 46;
            this.grdCriptos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCriptos_CellClick);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnBorrar.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.btnBorrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBorrar.BorderRadius = 0;
            this.btnBorrar.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(18, 189);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(91, 27);
            this.btnBorrar.TabIndex = 45;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.TextColor = System.Drawing.Color.White;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnMinimizarPantallaReg
            // 
            this.btnMinimizarPantallaReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizarPantallaReg.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMinimizarPantallaReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimizarPantallaReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarPantallaReg.FlatAppearance.BorderSize = 0;
            this.btnMinimizarPantallaReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarPantallaReg.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizarPantallaReg.IconColor = System.Drawing.SystemColors.Control;
            this.btnMinimizarPantallaReg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizarPantallaReg.IconSize = 20;
            this.btnMinimizarPantallaReg.Location = new System.Drawing.Point(571, 0);
            this.btnMinimizarPantallaReg.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizarPantallaReg.Name = "btnMinimizarPantallaReg";
            this.btnMinimizarPantallaReg.Size = new System.Drawing.Size(34, 20);
            this.btnMinimizarPantallaReg.TabIndex = 24;
            this.btnMinimizarPantallaReg.UseVisualStyleBackColor = false;
            this.btnMinimizarPantallaReg.Click += new System.EventHandler(this.btnMinimizarPantallaReg_Click);
            // 
            // btnCerrarPantallaReg
            // 
            this.btnCerrarPantallaReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarPantallaReg.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCerrarPantallaReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrarPantallaReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarPantallaReg.FlatAppearance.BorderSize = 0;
            this.btnCerrarPantallaReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPantallaReg.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrarPantallaReg.IconColor = System.Drawing.SystemColors.Control;
            this.btnCerrarPantallaReg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarPantallaReg.IconSize = 30;
            this.btnCerrarPantallaReg.Location = new System.Drawing.Point(605, 0);
            this.btnCerrarPantallaReg.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarPantallaReg.Name = "btnCerrarPantallaReg";
            this.btnCerrarPantallaReg.Size = new System.Drawing.Size(34, 20);
            this.btnCerrarPantallaReg.TabIndex = 23;
            this.btnCerrarPantallaReg.UseVisualStyleBackColor = false;
            this.btnCerrarPantallaReg.Click += new System.EventHandler(this.btnCerrarPantallaReg_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "codigo_cripto";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // Sigla
            // 
            this.Sigla.DataPropertyName = "siglas_cripto";
            this.Sigla.HeaderText = "Sigla";
            this.Sigla.Name = "Sigla";
            this.Sigla.ReadOnly = true;
            this.Sigla.Width = 60;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 250;
            // 
            // ABM_Criptomoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 340);
            this.Controls.Add(this.grdCriptos);
            this.Controls.Add(this.panelCriptos);
            this.Controls.Add(this.lblABM_Criptomoneda);
            this.Controls.Add(this.btnMinimizarPantallaReg);
            this.Controls.Add(this.btnCerrarPantallaReg);
            this.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ABM_Criptomoneda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM_Criptomoneda";
            this.Load += new System.EventHandler(this.ABM_Criptomoneda_Load);
            this.panelCriptos.ResumeLayout(false);
            this.panelCriptos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCriptos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnMinimizarPantallaReg;
        private FontAwesome.Sharp.IconButton btnCerrarPantallaReg;
        private System.Windows.Forms.Label lblABM_Criptomoneda;
        private System.Windows.Forms.Panel panelCriptos;
        private RJCodeAdvance.RJControls.RJButton btnCargar;
        private System.Windows.Forms.Label lblLimpiarCampos;
        private RJCodeAdvance.RJControls.RJButton btnActualizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombreCripto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label lblSiglaCripto;
        private System.Windows.Forms.Label lblNombreCripto;
        private System.Windows.Forms.DataGridView grdCriptos;
        private RJCodeAdvance.RJControls.RJButton btnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sigla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}