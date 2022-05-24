namespace Criptomonedas.Formularios_Ventanas_.ABM_s.Datos_Cliente
{
    partial class ABM_Ciudad
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
            this.lblABM_Barrio = new System.Windows.Forms.Label();
            this.grdCiudad = new System.Windows.Forms.DataGridView();
            this.btnMinimizarPantallaReg = new FontAwesome.Sharp.IconButton();
            this.btnCerrarPantallaReg = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnEliminar = new RJCodeAdvance.RJControls.RJButton();
            this.lblNombreBarrio = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            this.txtNombreCiudad = new System.Windows.Forms.TextBox();
            this.btnModificar = new RJCodeAdvance.RJControls.RJButton();
            this.lblLimpiarCampos = new System.Windows.Forms.Label();
            this.lblCiudadBarrio = new System.Windows.Forms.Label();
            this.cmbCodPvcia = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCiudad)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblABM_Barrio
            // 
            this.lblABM_Barrio.AutoSize = true;
            this.lblABM_Barrio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblABM_Barrio.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABM_Barrio.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblABM_Barrio.Location = new System.Drawing.Point(11, 18);
            this.lblABM_Barrio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblABM_Barrio.Name = "lblABM_Barrio";
            this.lblABM_Barrio.Size = new System.Drawing.Size(203, 36);
            this.lblABM_Barrio.TabIndex = 26;
            this.lblABM_Barrio.Text = "ABM Ciudad";
            // 
            // grdCiudad
            // 
            this.grdCiudad.AllowUserToAddRows = false;
            this.grdCiudad.AllowUserToDeleteRows = false;
            this.grdCiudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCiudad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Ciudad,
            this.Provincia});
            this.grdCiudad.Location = new System.Drawing.Point(301, 56);
            this.grdCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.grdCiudad.Name = "grdCiudad";
            this.grdCiudad.ReadOnly = true;
            this.grdCiudad.RowHeadersWidth = 51;
            this.grdCiudad.RowTemplate.Height = 24;
            this.grdCiudad.Size = new System.Drawing.Size(465, 300);
            this.grdCiudad.TabIndex = 52;
            this.grdCiudad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrCiudad_CellClick);
            this.grdCiudad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCiudad_CellContentClick);
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
            this.btnMinimizarPantallaReg.Location = new System.Drawing.Point(732, 0);
            this.btnMinimizarPantallaReg.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizarPantallaReg.Name = "btnMinimizarPantallaReg";
            this.btnMinimizarPantallaReg.Size = new System.Drawing.Size(34, 20);
            this.btnMinimizarPantallaReg.TabIndex = 54;
            this.btnMinimizarPantallaReg.UseVisualStyleBackColor = false;
            this.btnMinimizarPantallaReg.Click += new System.EventHandler(this.btnMinimizarPantallaReg_Click_1);
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
            this.btnCerrarPantallaReg.Location = new System.Drawing.Point(766, 0);
            this.btnCerrarPantallaReg.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarPantallaReg.Name = "btnCerrarPantallaReg";
            this.btnCerrarPantallaReg.Size = new System.Drawing.Size(34, 20);
            this.btnCerrarPantallaReg.TabIndex = 53;
            this.btnCerrarPantallaReg.UseVisualStyleBackColor = false;
            this.btnCerrarPantallaReg.Click += new System.EventHandler(this.btnCerrarPantallaReg_Click_1);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnEliminar);
            this.panel5.Controls.Add(this.lblNombreBarrio);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.btnGuardar);
            this.panel5.Controls.Add(this.txtNombreCiudad);
            this.panel5.Controls.Add(this.btnModificar);
            this.panel5.Controls.Add(this.lblLimpiarCampos);
            this.panel5.Controls.Add(this.lblCiudadBarrio);
            this.panel5.Controls.Add(this.cmbCodPvcia);
            this.panel5.Location = new System.Drawing.Point(17, 56);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 301);
            this.panel5.TabIndex = 55;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnEliminar.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.btnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BorderRadius = 0;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(12, 260);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 27);
            this.btnEliminar.TabIndex = 65;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // lblNombreBarrio
            // 
            this.lblNombreBarrio.AutoSize = true;
            this.lblNombreBarrio.BackColor = System.Drawing.SystemColors.Control;
            this.lblNombreBarrio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblNombreBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreBarrio.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblNombreBarrio.Location = new System.Drawing.Point(-4, 12);
            this.lblNombreBarrio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreBarrio.Name = "lblNombreBarrio";
            this.lblNombreBarrio.Size = new System.Drawing.Size(58, 15);
            this.lblNombreBarrio.TabIndex = 58;
            this.lblNombreBarrio.Text = "Nombre";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel3.Location = new System.Drawing.Point(-1, 104);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 64;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Location = new System.Drawing.Point(-1, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 63;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnGuardar.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.btnGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.BorderRadius = 0;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(12, 197);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 27);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "CARGAR";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardarTipoDoc_Click);
            // 
            // txtNombreCiudad
            // 
            this.txtNombreCiudad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCiudad.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNombreCiudad.Location = new System.Drawing.Point(-1, 27);
            this.txtNombreCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCiudad.Multiline = true;
            this.txtNombreCiudad.Name = "txtNombreCiudad";
            this.txtNombreCiudad.Size = new System.Drawing.Size(200, 30);
            this.txtNombreCiudad.TabIndex = 57;
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
            this.btnModificar.Location = new System.Drawing.Point(12, 227);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(91, 29);
            this.btnModificar.TabIndex = 27;
            this.btnModificar.Text = "ACTUALIZAR";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // lblLimpiarCampos
            // 
            this.lblLimpiarCampos.AutoSize = true;
            this.lblLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimpiarCampos.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblLimpiarCampos.Location = new System.Drawing.Point(154, 136);
            this.lblLimpiarCampos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLimpiarCampos.Name = "lblLimpiarCampos";
            this.lblLimpiarCampos.Size = new System.Drawing.Size(112, 15);
            this.lblLimpiarCampos.TabIndex = 56;
            this.lblLimpiarCampos.Text = "Limpiar Campos";
            this.lblLimpiarCampos.Click += new System.EventHandler(this.lblLimpiarCampos_Click_1);
            // 
            // lblCiudadBarrio
            // 
            this.lblCiudadBarrio.AutoSize = true;
            this.lblCiudadBarrio.BackColor = System.Drawing.SystemColors.Control;
            this.lblCiudadBarrio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblCiudadBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudadBarrio.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblCiudadBarrio.Location = new System.Drawing.Point(-4, 61);
            this.lblCiudadBarrio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCiudadBarrio.Name = "lblCiudadBarrio";
            this.lblCiudadBarrio.Size = new System.Drawing.Size(66, 15);
            this.lblCiudadBarrio.TabIndex = 59;
            this.lblCiudadBarrio.Text = "Provincia";
            // 
            // cmbCodPvcia
            // 
            this.cmbCodPvcia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodPvcia.FormattingEnabled = true;
            this.cmbCodPvcia.Location = new System.Drawing.Point(-2, 79);
            this.cmbCodPvcia.Name = "cmbCodPvcia";
            this.cmbCodPvcia.Size = new System.Drawing.Size(200, 26);
            this.cmbCodPvcia.TabIndex = 60;
            this.cmbCodPvcia.SelectedIndexChanged += new System.EventHandler(this.cmbCodPvcia_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "cod_ciudad";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Ciudad
            // 
            this.Ciudad.DataPropertyName = "nombre_ciudad";
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // Provincia
            // 
            this.Provincia.DataPropertyName = "cod_provincia";
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            // 
            // ABM_Ciudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnMinimizarPantallaReg);
            this.Controls.Add(this.btnCerrarPantallaReg);
            this.Controls.Add(this.grdCiudad);
            this.Controls.Add(this.lblABM_Barrio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ABM_Ciudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM_Ciudades";
            this.Load += new System.EventHandler(this.ABM_Ciudades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCiudad)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblABM_Barrio;
        private System.Windows.Forms.DataGridView grdCiudad;
        private FontAwesome.Sharp.IconButton btnMinimizarPantallaReg;
        private FontAwesome.Sharp.IconButton btnCerrarPantallaReg;
        private System.Windows.Forms.Panel panel5;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private RJCodeAdvance.RJControls.RJButton btnModificar;
        private System.Windows.Forms.Label lblLimpiarCampos;
        private System.Windows.Forms.Label lblNombreBarrio;
        private System.Windows.Forms.TextBox txtNombreCiudad;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCiudadBarrio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCodPvcia;
        private RJCodeAdvance.RJControls.RJButton btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
    }
}