namespace Criptomonedas.Transacciones.Ventanas
{
    partial class ABM_Compra
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
            this.lblHora = new System.Windows.Forms.Label();
            this.grillaCripto = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblModificar = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnComprar = new RJCodeAdvance.RJControls.RJButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.lblCantidadEnMonedero = new System.Windows.Forms.Label();
            this.grillaCompras = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_cripto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_monedero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.btnAgregarCompra = new RJCodeAdvance.RJControls.RJButton();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.comboCriptomonedas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNombreCripto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMinimizarPantalla = new FontAwesome.Sharp.IconButton();
            this.btnCerrarPantalla = new FontAwesome.Sharp.IconButton();
            this.cripto_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_cripto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_cripto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCripto)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.grillaCripto);
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 458);
            this.panel1.TabIndex = 5;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblHora.Location = new System.Drawing.Point(3, 3);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(54, 17);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "label1";
            // 
            // grillaCripto
            // 
            this.grillaCripto.AllowUserToAddRows = false;
            this.grillaCripto.AllowUserToDeleteRows = false;
            this.grillaCripto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grillaCripto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCripto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cripto_nombre,
            this.codigo_cripto,
            this.valor_cripto});
            this.grillaCripto.Location = new System.Drawing.Point(5, 23);
            this.grillaCripto.Name = "grillaCripto";
            this.grillaCripto.ReadOnly = true;
            this.grillaCripto.Size = new System.Drawing.Size(253, 328);
            this.grillaCripto.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblModificar);
            this.panel2.Location = new System.Drawing.Point(12, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 57);
            this.panel2.TabIndex = 6;
            // 
            // lblModificar
            // 
            this.lblModificar.AutoEllipsis = true;
            this.lblModificar.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.ForeColor = System.Drawing.Color.Lime;
            this.lblModificar.Location = new System.Drawing.Point(2, 2);
            this.lblModificar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(256, 55);
            this.lblModificar.TabIndex = 17;
            this.lblModificar.Text = "Comprar";
            this.lblModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnComprar);
            this.panel3.Controls.Add(this.iconPictureBox2);
            this.panel3.Controls.Add(this.lblCantidadEnMonedero);
            this.panel3.Controls.Add(this.grillaCompras);
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Controls.Add(this.iconPictureBox4);
            this.panel3.Controls.Add(this.btnAgregarCompra);
            this.panel3.Controls.Add(this.textBoxCantidad);
            this.panel3.Controls.Add(this.comboCriptomonedas);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.labelNombreCripto);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(279, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(532, 521);
            this.panel3.TabIndex = 7;
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnComprar.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.btnComprar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnComprar.BorderRadius = 0;
            this.btnComprar.BorderSize = 0;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.Location = new System.Drawing.Point(17, 286);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(2);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(132, 27);
            this.btnComprar.TabIndex = 50;
            this.btnComprar.Text = "COMPRAR";
            this.btnComprar.TextColor = System.Drawing.Color.White;
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Lime;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Lime;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 42;
            this.iconPictureBox2.ImageLocation = "";
            this.iconPictureBox2.Location = new System.Drawing.Point(339, 63);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(43, 42);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox2.TabIndex = 49;
            this.iconPictureBox2.TabStop = false;
            // 
            // lblCantidadEnMonedero
            // 
            this.lblCantidadEnMonedero.AutoSize = true;
            this.lblCantidadEnMonedero.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadEnMonedero.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCantidadEnMonedero.Location = new System.Drawing.Point(387, 77);
            this.lblCantidadEnMonedero.Name = "lblCantidadEnMonedero";
            this.lblCantidadEnMonedero.Size = new System.Drawing.Size(27, 18);
            this.lblCantidadEnMonedero.TabIndex = 48;
            this.lblCantidadEnMonedero.Text = "lbl";
            // 
            // grillaCompras
            // 
            this.grillaCompras.AllowUserToAddRows = false;
            this.grillaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.cod_cripto,
            this.cod_monedero,
            this.cantidad,
            this.valor,
            this.total});
            this.grillaCompras.Location = new System.Drawing.Point(17, 131);
            this.grillaCompras.Name = "grillaCompras";
            this.grillaCompras.ReadOnly = true;
            this.grillaCompras.Size = new System.Drawing.Size(314, 150);
            this.grillaCompras.TabIndex = 47;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Criptomoneda";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 80;
            // 
            // cod_cripto
            // 
            this.cod_cripto.HeaderText = "Codigo Criptomoneda";
            this.cod_cripto.Name = "cod_cripto";
            this.cod_cripto.ReadOnly = true;
            this.cod_cripto.Visible = false;
            // 
            // cod_monedero
            // 
            this.cod_monedero.DataPropertyName = "cod_monedero";
            this.cod_monedero.HeaderText = "Codigo Monedero";
            this.cod_monedero.Name = "cod_monedero";
            this.cod_monedero.ReadOnly = true;
            this.cod_monedero.Visible = false;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 60;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 60;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 60;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Lime;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Lime;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 31;
            this.iconPictureBox1.ImageLocation = "";
            this.iconPictureBox1.Location = new System.Drawing.Point(175, 63);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(31, 31);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 46;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox4.ForeColor = System.Drawing.Color.Lime;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.iconPictureBox4.IconColor = System.Drawing.Color.Lime;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 31;
            this.iconPictureBox4.Location = new System.Drawing.Point(17, 63);
            this.iconPictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(31, 32);
            this.iconPictureBox4.TabIndex = 45;
            this.iconPictureBox4.TabStop = false;
            // 
            // btnAgregarCompra
            // 
            this.btnAgregarCompra.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnAgregarCompra.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.btnAgregarCompra.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarCompra.BorderRadius = 0;
            this.btnAgregarCompra.BorderSize = 0;
            this.btnAgregarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCompra.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCompra.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCompra.Location = new System.Drawing.Point(17, 99);
            this.btnAgregarCompra.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarCompra.Name = "btnAgregarCompra";
            this.btnAgregarCompra.Size = new System.Drawing.Size(132, 27);
            this.btnAgregarCompra.TabIndex = 23;
            this.btnAgregarCompra.Text = "AGREGAR";
            this.btnAgregarCompra.TextColor = System.Drawing.Color.White;
            this.btnAgregarCompra.UseVisualStyleBackColor = false;
            this.btnAgregarCompra.Click += new System.EventHandler(this.btnAgregarCompra_Click);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(211, 69);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(110, 20);
            this.textBoxCantidad.TabIndex = 22;
            // 
            // comboCriptomonedas
            // 
            this.comboCriptomonedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCriptomonedas.FormattingEnabled = true;
            this.comboCriptomonedas.Location = new System.Drawing.Point(53, 68);
            this.comboCriptomonedas.Name = "comboCriptomonedas";
            this.comboCriptomonedas.Size = new System.Drawing.Size(117, 21);
            this.comboCriptomonedas.TabIndex = 21;
            this.comboCriptomonedas.SelectedIndexChanged += new System.EventHandler(this.comboCriptomonedas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(172, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cantidad";
            // 
            // labelNombreCripto
            // 
            this.labelNombreCripto.AutoSize = true;
            this.labelNombreCripto.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCripto.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelNombreCripto.Location = new System.Drawing.Point(14, 48);
            this.labelNombreCripto.Name = "labelNombreCripto";
            this.labelNombreCripto.Size = new System.Drawing.Size(69, 17);
            this.labelNombreCripto.TabIndex = 7;
            this.labelNombreCripto.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Seleccione las Criptomonedas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(615, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Cantidad en Monedero";
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
            this.btnMinimizarPantalla.Location = new System.Drawing.Point(746, 0);
            this.btnMinimizarPantalla.Name = "btnMinimizarPantalla";
            this.btnMinimizarPantalla.Size = new System.Drawing.Size(34, 20);
            this.btnMinimizarPantalla.TabIndex = 4;
            this.btnMinimizarPantalla.UseVisualStyleBackColor = false;
            this.btnMinimizarPantalla.Click += new System.EventHandler(this.btnMinimizarPantalla_Click);
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
            this.btnCerrarPantalla.Location = new System.Drawing.Point(780, 0);
            this.btnCerrarPantalla.Name = "btnCerrarPantalla";
            this.btnCerrarPantalla.Size = new System.Drawing.Size(34, 20);
            this.btnCerrarPantalla.TabIndex = 3;
            this.btnCerrarPantalla.UseVisualStyleBackColor = false;
            this.btnCerrarPantalla.Click += new System.EventHandler(this.btnCerrarPantalla_Click);
            // 
            // cripto_nombre
            // 
            this.cripto_nombre.DataPropertyName = "nombre";
            this.cripto_nombre.HeaderText = "Criptomoneda";
            this.cripto_nombre.Name = "cripto_nombre";
            this.cripto_nombre.ReadOnly = true;
            // 
            // codigo_cripto
            // 
            this.codigo_cripto.DataPropertyName = "codigo_cripto";
            this.codigo_cripto.HeaderText = "codigo_cripto";
            this.codigo_cripto.Name = "codigo_cripto";
            this.codigo_cripto.ReadOnly = true;
            this.codigo_cripto.Visible = false;
            // 
            // valor_cripto
            // 
            this.valor_cripto.DataPropertyName = "valor";
            this.valor_cripto.HeaderText = "Precio";
            this.valor_cripto.Name = "valor_cripto";
            this.valor_cripto.ReadOnly = true;
            // 
            // ABM_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMinimizarPantalla);
            this.Controls.Add(this.btnCerrarPantalla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ABM_Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM_Compra";
            this.Load += new System.EventHandler(this.ABM_Compra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCripto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCerrarPantalla;
        private FontAwesome.Sharp.IconButton btnMinimizarPantalla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DataGridView grillaCripto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Label labelNombreCripto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.ComboBox comboCriptomonedas;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJButton btnAgregarCompra;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private System.Windows.Forms.DataGridView grillaCompras;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label lblCantidadEnMonedero;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJButton btnComprar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_cripto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_monedero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn cripto_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_cripto;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_cripto;
    }
}