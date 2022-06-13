namespace Criptomonedas.Formularios_Ventanas_.ABM_s.Criptomonedas
{
    partial class ABM_Monedero
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCantPrueba = new System.Windows.Forms.TextBox();
            this.btnEliminar = new RJCodeAdvance.RJControls.RJButton();
            this.cmbNroCliente = new System.Windows.Forms.ComboBox();
            this.cmbCodCripto = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCargar = new RJCodeAdvance.RJControls.RJButton();
            this.btnModificar = new RJCodeAdvance.RJControls.RJButton();
            this.lblNroClienteCripto = new System.Windows.Forms.Label();
            this.lblLimpiarCampos = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCantidadCripto = new System.Windows.Forms.Label();
            this.lblCodigoCripto = new System.Windows.Forms.Label();
            this.lblABM_Monedero = new System.Windows.Forms.Label();
            this.grdMonedero = new System.Windows.Forms.DataGridView();
            this.btnMinimizarPantallaReg = new FontAwesome.Sharp.IconButton();
            this.btnCerrarPantallaReg = new FontAwesome.Sharp.IconButton();
            this.Codigo_Monedero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Cripto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMonedero)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCantPrueba);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.cmbNroCliente);
            this.panel1.Controls.Add(this.cmbCodCripto);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCargar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.lblNroClienteCripto);
            this.panel1.Controls.Add(this.lblLimpiarCampos);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblCantidadCripto);
            this.panel1.Controls.Add(this.lblCodigoCripto);
            this.panel1.Location = new System.Drawing.Point(9, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 277);
            this.panel1.TabIndex = 41;
            // 
            // txtCantPrueba
            // 
            this.txtCantPrueba.Location = new System.Drawing.Point(21, 85);
            this.txtCantPrueba.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantPrueba.Name = "txtCantPrueba";
            this.txtCantPrueba.Size = new System.Drawing.Size(110, 20);
            this.txtCantPrueba.TabIndex = 59;
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
            this.btnEliminar.Location = new System.Drawing.Point(117, 245);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 27);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cmbNroCliente
            // 
            this.cmbNroCliente.FormattingEnabled = true;
            this.cmbNroCliente.Location = new System.Drawing.Point(23, 142);
            this.cmbNroCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbNroCliente.Name = "cmbNroCliente";
            this.cmbNroCliente.Size = new System.Drawing.Size(53, 21);
            this.cmbNroCliente.TabIndex = 57;
            // 
            // cmbCodCripto
            // 
            this.cmbCodCripto.DropDownWidth = 69;
            this.cmbCodCripto.FormattingEnabled = true;
            this.cmbCodCripto.Location = new System.Drawing.Point(22, 32);
            this.cmbCodCripto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCodCripto.Name = "cmbCodCripto";
            this.cmbCodCripto.Size = new System.Drawing.Size(53, 21);
            this.cmbCodCripto.TabIndex = 56;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Location = new System.Drawing.Point(23, 163);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(52, 1);
            this.panel2.TabIndex = 55;
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
            this.btnCargar.Location = new System.Drawing.Point(22, 215);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(91, 27);
            this.btnCargar.TabIndex = 53;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.TextColor = System.Drawing.Color.White;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(117, 215);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(91, 27);
            this.btnModificar.TabIndex = 52;
            this.btnModificar.Text = "ACTUALIZAR";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblNroClienteCripto
            // 
            this.lblNroClienteCripto.AutoSize = true;
            this.lblNroClienteCripto.BackColor = System.Drawing.SystemColors.Control;
            this.lblNroClienteCripto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblNroClienteCripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroClienteCripto.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblNroClienteCripto.Location = new System.Drawing.Point(21, 120);
            this.lblNroClienteCripto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNroClienteCripto.Name = "lblNroClienteCripto";
            this.lblNroClienteCripto.Size = new System.Drawing.Size(127, 15);
            this.lblNroClienteCripto.TabIndex = 46;
            this.lblNroClienteCripto.Text = "Número de Cliente";
            // 
            // lblLimpiarCampos
            // 
            this.lblLimpiarCampos.AutoSize = true;
            this.lblLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimpiarCampos.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblLimpiarCampos.Location = new System.Drawing.Point(140, 163);
            this.lblLimpiarCampos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLimpiarCampos.Name = "lblLimpiarCampos";
            this.lblLimpiarCampos.Size = new System.Drawing.Size(112, 15);
            this.lblLimpiarCampos.TabIndex = 43;
            this.lblLimpiarCampos.Text = "Limpiar Campos";
            this.lblLimpiarCampos.Click += new System.EventHandler(this.lblLimpiarCampos_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel3.Location = new System.Drawing.Point(22, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(52, 1);
            this.panel3.TabIndex = 42;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel4.Location = new System.Drawing.Point(21, 107);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(110, 1);
            this.panel4.TabIndex = 41;
            // 
            // lblCantidadCripto
            // 
            this.lblCantidadCripto.AutoSize = true;
            this.lblCantidadCripto.BackColor = System.Drawing.SystemColors.Control;
            this.lblCantidadCripto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblCantidadCripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadCripto.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblCantidadCripto.Location = new System.Drawing.Point(20, 65);
            this.lblCantidadCripto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadCripto.Name = "lblCantidadCripto";
            this.lblCantidadCripto.Size = new System.Drawing.Size(64, 15);
            this.lblCantidadCripto.TabIndex = 40;
            this.lblCantidadCripto.Text = "Cantidad";
            // 
            // lblCodigoCripto
            // 
            this.lblCodigoCripto.AutoSize = true;
            this.lblCodigoCripto.BackColor = System.Drawing.SystemColors.Control;
            this.lblCodigoCripto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblCodigoCripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCripto.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblCodigoCripto.Location = new System.Drawing.Point(20, 14);
            this.lblCodigoCripto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoCripto.Name = "lblCodigoCripto";
            this.lblCodigoCripto.Size = new System.Drawing.Size(146, 15);
            this.lblCodigoCripto.TabIndex = 39;
            this.lblCodigoCripto.Text = "Código Criptomoneda";
            // 
            // lblABM_Monedero
            // 
            this.lblABM_Monedero.AutoSize = true;
            this.lblABM_Monedero.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblABM_Monedero.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABM_Monedero.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblABM_Monedero.Location = new System.Drawing.Point(9, 7);
            this.lblABM_Monedero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblABM_Monedero.Name = "lblABM_Monedero";
            this.lblABM_Monedero.Size = new System.Drawing.Size(242, 36);
            this.lblABM_Monedero.TabIndex = 39;
            this.lblABM_Monedero.Text = "ABM Monedero";
            // 
            // grdMonedero
            // 
            this.grdMonedero.AllowUserToAddRows = false;
            this.grdMonedero.AllowUserToDeleteRows = false;
            this.grdMonedero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMonedero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Monedero,
            this.Codigo_Cripto,
            this.Cantidad,
            this.nombre,
            this.apellido});
            this.grdMonedero.Location = new System.Drawing.Point(271, 63);
            this.grdMonedero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdMonedero.Name = "grdMonedero";
            this.grdMonedero.ReadOnly = true;
            this.grdMonedero.RowHeadersWidth = 51;
            this.grdMonedero.RowTemplate.Height = 24;
            this.grdMonedero.Size = new System.Drawing.Size(614, 277);
            this.grdMonedero.TabIndex = 42;
            this.grdMonedero.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMonedero_CellClick);
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
            this.btnMinimizarPantallaReg.Location = new System.Drawing.Point(833, 0);
            this.btnMinimizarPantallaReg.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizarPantallaReg.Name = "btnMinimizarPantallaReg";
            this.btnMinimizarPantallaReg.Size = new System.Drawing.Size(34, 20);
            this.btnMinimizarPantallaReg.TabIndex = 44;
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
            this.btnCerrarPantallaReg.Location = new System.Drawing.Point(867, 0);
            this.btnCerrarPantallaReg.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarPantallaReg.Name = "btnCerrarPantallaReg";
            this.btnCerrarPantallaReg.Size = new System.Drawing.Size(34, 20);
            this.btnCerrarPantallaReg.TabIndex = 43;
            this.btnCerrarPantallaReg.UseVisualStyleBackColor = false;
            this.btnCerrarPantallaReg.Click += new System.EventHandler(this.btnCerrarPantallaReg_Click);
            // 
            // Codigo_Monedero
            // 
            this.Codigo_Monedero.DataPropertyName = "cod_monedero";
            this.Codigo_Monedero.HeaderText = "Cod. Monedero";
            this.Codigo_Monedero.MinimumWidth = 6;
            this.Codigo_Monedero.Name = "Codigo_Monedero";
            this.Codigo_Monedero.ReadOnly = true;
            this.Codigo_Monedero.Width = 125;
            // 
            // Codigo_Cripto
            // 
            this.Codigo_Cripto.DataPropertyName = "codigo_cripto";
            this.Codigo_Cripto.HeaderText = "Cod. Criptomoneda";
            this.Codigo_Cripto.MinimumWidth = 6;
            this.Codigo_Cripto.Name = "Codigo_Cripto";
            this.Codigo_Cripto.ReadOnly = true;
            this.Codigo_Cripto.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // ABM_Monedero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 342);
            this.Controls.Add(this.btnMinimizarPantallaReg);
            this.Controls.Add(this.btnCerrarPantallaReg);
            this.Controls.Add(this.grdMonedero);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblABM_Monedero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ABM_Monedero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM_Mondero";
            this.Load += new System.EventHandler(this.ABM_Monedero_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMonedero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLimpiarCampos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCantidadCripto;
        private System.Windows.Forms.Label lblCodigoCripto;
        private System.Windows.Forms.Label lblABM_Monedero;
        private System.Windows.Forms.DataGridView grdMonedero;
        private System.Windows.Forms.Label lblNroClienteCripto;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJButton btnCargar;
        private RJCodeAdvance.RJControls.RJButton btnModificar;
        private System.Windows.Forms.ComboBox cmbNroCliente;
        private System.Windows.Forms.ComboBox cmbCodCripto;
        private FontAwesome.Sharp.IconButton btnMinimizarPantallaReg;
        private FontAwesome.Sharp.IconButton btnCerrarPantallaReg;
        private RJCodeAdvance.RJControls.RJButton btnEliminar;
        private System.Windows.Forms.TextBox txtCantPrueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Monedero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Cripto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
    }
}