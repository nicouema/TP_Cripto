namespace Criptomonedas.Formularios_Ventanas_.ABM_s.Datos_Cliente
{
    partial class ABM_TipoDocumento
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
            this.lblABM_TipoDocumento = new System.Windows.Forms.Label();
            this.grdTipoDoc = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardarTipoDoc = new RJCodeAdvance.RJControls.RJButton();
            this.btnModificarTipoDoc = new RJCodeAdvance.RJControls.RJButton();
            this.lblLimpiarCampos = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDescTipoDoc = new System.Windows.Forms.Label();
            this.lblNombreTipoDoc = new System.Windows.Forms.Label();
            this.txtNombreDoc = new System.Windows.Forms.TextBox();
            this.txtDescDoc = new System.Windows.Forms.TextBox();
            this.btnMinimizarPantallaReg = new FontAwesome.Sharp.IconButton();
            this.btnCerrarPantallaReg = new FontAwesome.Sharp.IconButton();
            this.CodigoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoDoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblABM_TipoDocumento
            // 
            this.lblABM_TipoDocumento.AutoSize = true;
            this.lblABM_TipoDocumento.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblABM_TipoDocumento.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABM_TipoDocumento.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblABM_TipoDocumento.Location = new System.Drawing.Point(12, 22);
            this.lblABM_TipoDocumento.Name = "lblABM_TipoDocumento";
            this.lblABM_TipoDocumento.Size = new System.Drawing.Size(478, 45);
            this.lblABM_TipoDocumento.TabIndex = 17;
            this.lblABM_TipoDocumento.Text = "ABM Tipo de Documento";
            // 
            // grdTipoDoc
            // 
            this.grdTipoDoc.AllowUserToAddRows = false;
            this.grdTipoDoc.AllowUserToDeleteRows = false;
            this.grdTipoDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTipoDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDocumento,
            this.TipoDocumento,
            this.Descripción});
            this.grdTipoDoc.Location = new System.Drawing.Point(291, 94);
            this.grdTipoDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdTipoDoc.Name = "grdTipoDoc";
            this.grdTipoDoc.ReadOnly = true;
            this.grdTipoDoc.RowHeadersWidth = 51;
            this.grdTipoDoc.RowTemplate.Height = 24;
            this.grdTipoDoc.Size = new System.Drawing.Size(819, 324);
            this.grdTipoDoc.TabIndex = 30;
            this.grdTipoDoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTipoDoc_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuardarTipoDoc);
            this.panel1.Controls.Add(this.btnModificarTipoDoc);
            this.panel1.Controls.Add(this.lblLimpiarCampos);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblDescTipoDoc);
            this.panel1.Controls.Add(this.lblNombreTipoDoc);
            this.panel1.Controls.Add(this.txtNombreDoc);
            this.panel1.Controls.Add(this.txtDescDoc);
            this.panel1.Location = new System.Drawing.Point(12, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 311);
            this.panel1.TabIndex = 38;
            // 
            // btnGuardarTipoDoc
            // 
            this.btnGuardarTipoDoc.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnGuardarTipoDoc.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.btnGuardarTipoDoc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarTipoDoc.BorderRadius = 0;
            this.btnGuardarTipoDoc.BorderSize = 0;
            this.btnGuardarTipoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTipoDoc.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTipoDoc.ForeColor = System.Drawing.Color.White;
            this.btnGuardarTipoDoc.Location = new System.Drawing.Point(8, 276);
            this.btnGuardarTipoDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarTipoDoc.Name = "btnGuardarTipoDoc";
            this.btnGuardarTipoDoc.Size = new System.Drawing.Size(121, 33);
            this.btnGuardarTipoDoc.TabIndex = 45;
            this.btnGuardarTipoDoc.Text = "CARGAR";
            this.btnGuardarTipoDoc.TextColor = System.Drawing.Color.White;
            this.btnGuardarTipoDoc.UseVisualStyleBackColor = false;
            this.btnGuardarTipoDoc.Click += new System.EventHandler(this.btnGuardarTipoDoc_Click);
            // 
            // btnModificarTipoDoc
            // 
            this.btnModificarTipoDoc.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnModificarTipoDoc.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.btnModificarTipoDoc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModificarTipoDoc.BorderRadius = 0;
            this.btnModificarTipoDoc.BorderSize = 0;
            this.btnModificarTipoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTipoDoc.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTipoDoc.ForeColor = System.Drawing.Color.White;
            this.btnModificarTipoDoc.Location = new System.Drawing.Point(135, 275);
            this.btnModificarTipoDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarTipoDoc.Name = "btnModificarTipoDoc";
            this.btnModificarTipoDoc.Size = new System.Drawing.Size(121, 34);
            this.btnModificarTipoDoc.TabIndex = 44;
            this.btnModificarTipoDoc.Text = "ACTUALIZAR";
            this.btnModificarTipoDoc.TextColor = System.Drawing.Color.White;
            this.btnModificarTipoDoc.UseVisualStyleBackColor = false;
            this.btnModificarTipoDoc.Click += new System.EventHandler(this.btnModificarTipoDoc_Click);
            // 
            // lblLimpiarCampos
            // 
            this.lblLimpiarCampos.AutoSize = true;
            this.lblLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimpiarCampos.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblLimpiarCampos.Location = new System.Drawing.Point(102, 147);
            this.lblLimpiarCampos.Name = "lblLimpiarCampos";
            this.lblLimpiarCampos.Size = new System.Drawing.Size(131, 18);
            this.lblLimpiarCampos.TabIndex = 43;
            this.lblLimpiarCampos.Text = "Limpiar Campos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel3.Location = new System.Drawing.Point(28, 64);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 1);
            this.panel3.TabIndex = 42;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel4.Location = new System.Drawing.Point(28, 132);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(204, 1);
            this.panel4.TabIndex = 41;
            // 
            // lblDescTipoDoc
            // 
            this.lblDescTipoDoc.AutoSize = true;
            this.lblDescTipoDoc.BackColor = System.Drawing.SystemColors.Control;
            this.lblDescTipoDoc.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblDescTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescTipoDoc.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblDescTipoDoc.Location = new System.Drawing.Point(26, 80);
            this.lblDescTipoDoc.Name = "lblDescTipoDoc";
            this.lblDescTipoDoc.Size = new System.Drawing.Size(98, 18);
            this.lblDescTipoDoc.TabIndex = 40;
            this.lblDescTipoDoc.Text = "Descripción";
            // 
            // lblNombreTipoDoc
            // 
            this.lblNombreTipoDoc.AutoSize = true;
            this.lblNombreTipoDoc.BackColor = System.Drawing.SystemColors.Control;
            this.lblNombreTipoDoc.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblNombreTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTipoDoc.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblNombreTipoDoc.Location = new System.Drawing.Point(26, 17);
            this.lblNombreTipoDoc.Name = "lblNombreTipoDoc";
            this.lblNombreTipoDoc.Size = new System.Drawing.Size(68, 18);
            this.lblNombreTipoDoc.TabIndex = 39;
            this.lblNombreTipoDoc.Text = "Nombre";
            // 
            // txtNombreDoc
            // 
            this.txtNombreDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDoc.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNombreDoc.Location = new System.Drawing.Point(28, 40);
            this.txtNombreDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreDoc.Multiline = true;
            this.txtNombreDoc.Name = "txtNombreDoc";
            this.txtNombreDoc.Size = new System.Drawing.Size(204, 25);
            this.txtNombreDoc.TabIndex = 37;
            // 
            // txtDescDoc
            // 
            this.txtDescDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescDoc.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDescDoc.Location = new System.Drawing.Point(30, 104);
            this.txtDescDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescDoc.Multiline = true;
            this.txtDescDoc.Name = "txtDescDoc";
            this.txtDescDoc.Size = new System.Drawing.Size(204, 25);
            this.txtDescDoc.TabIndex = 38;
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
            this.btnMinimizarPantallaReg.Location = new System.Drawing.Point(1021, 0);
            this.btnMinimizarPantallaReg.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizarPantallaReg.Name = "btnMinimizarPantallaReg";
            this.btnMinimizarPantallaReg.Size = new System.Drawing.Size(45, 25);
            this.btnMinimizarPantallaReg.TabIndex = 22;
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
            this.btnCerrarPantallaReg.Location = new System.Drawing.Point(1067, 0);
            this.btnCerrarPantallaReg.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarPantallaReg.Name = "btnCerrarPantallaReg";
            this.btnCerrarPantallaReg.Size = new System.Drawing.Size(45, 25);
            this.btnCerrarPantallaReg.TabIndex = 21;
            this.btnCerrarPantallaReg.UseVisualStyleBackColor = false;
            this.btnCerrarPantallaReg.Click += new System.EventHandler(this.btnCerrarPantallaReg_Click);
            // 
            // CodigoDocumento
            // 
            this.CodigoDocumento.HeaderText = "Cod. Documento";
            this.CodigoDocumento.MinimumWidth = 6;
            this.CodigoDocumento.Name = "CodigoDocumento";
            this.CodigoDocumento.ReadOnly = true;
            this.CodigoDocumento.Width = 125;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "tipo_doc";
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.MinimumWidth = 6;
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            this.TipoDocumento.Width = 300;
            // 
            // Descripción
            // 
            this.Descripción.DataPropertyName = "descripcion";
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.MinimumWidth = 6;
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            this.Descripción.Width = 1000;
            // 
            // ABM_TipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdTipoDoc);
            this.Controls.Add(this.btnMinimizarPantallaReg);
            this.Controls.Add(this.btnCerrarPantallaReg);
            this.Controls.Add(this.lblABM_TipoDocumento);
            this.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ABM_TipoDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM_TipoDocumento";
            this.Load += new System.EventHandler(this.ABM_TipoDocumento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoDoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblABM_TipoDocumento;
        private FontAwesome.Sharp.IconButton btnMinimizarPantallaReg;
        private FontAwesome.Sharp.IconButton btnCerrarPantallaReg;
        private System.Windows.Forms.DataGridView grdTipoDoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLimpiarCampos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDescTipoDoc;
        private System.Windows.Forms.Label lblNombreTipoDoc;
        private System.Windows.Forms.TextBox txtNombreDoc;
        private System.Windows.Forms.TextBox txtDescDoc;
        private RJCodeAdvance.RJControls.RJButton btnGuardarTipoDoc;
        private RJCodeAdvance.RJControls.RJButton btnModificarTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
    }
}