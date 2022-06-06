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
            this.btnCerrarPantalla = new FontAwesome.Sharp.IconButton();
            this.btnMinimizarPantalla = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.grillaCripto = new System.Windows.Forms.DataGridView();
            this.cripno_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblModificar = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelNombreCripto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCriptomonedas = new System.Windows.Forms.ComboBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregarCompra = new RJCodeAdvance.RJControls.RJButton();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCripto)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnCerrarPantalla.Location = new System.Drawing.Point(766, 0);
            this.btnCerrarPantalla.Name = "btnCerrarPantalla";
            this.btnCerrarPantalla.Size = new System.Drawing.Size(34, 20);
            this.btnCerrarPantalla.TabIndex = 3;
            this.btnCerrarPantalla.UseVisualStyleBackColor = false;
            this.btnCerrarPantalla.Click += new System.EventHandler(this.btnCerrarPantalla_Click);
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
            this.btnMinimizarPantalla.Location = new System.Drawing.Point(732, 0);
            this.btnMinimizarPantalla.Name = "btnMinimizarPantalla";
            this.btnMinimizarPantalla.Size = new System.Drawing.Size(34, 20);
            this.btnMinimizarPantalla.TabIndex = 4;
            this.btnMinimizarPantalla.UseVisualStyleBackColor = false;
            this.btnMinimizarPantalla.Click += new System.EventHandler(this.btnMinimizarPantalla_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.grillaCripto);
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 354);
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
            this.cripno_nombre,
            this.precio});
            this.grillaCripto.Location = new System.Drawing.Point(5, 23);
            this.grillaCripto.Name = "grillaCripto";
            this.grillaCripto.ReadOnly = true;
            this.grillaCripto.Size = new System.Drawing.Size(253, 328);
            this.grillaCripto.TabIndex = 4;
            // 
            // cripno_nombre
            // 
            this.cripno_nombre.DataPropertyName = "nombre";
            this.cripno_nombre.HeaderText = "Criptomoneda";
            this.cripno_nombre.Name = "cripno_nombre";
            this.cripno_nombre.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "valor";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
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
            this.lblModificar.ForeColor = System.Drawing.Color.MediumSpringGreen;
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
            this.panel3.Size = new System.Drawing.Size(521, 417);
            this.panel3.TabIndex = 7;
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
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Seleccione las Criptomonedas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // comboCriptomonedas
            // 
            this.comboCriptomonedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCriptomonedas.FormattingEnabled = true;
            this.comboCriptomonedas.Location = new System.Drawing.Point(53, 68);
            this.comboCriptomonedas.Name = "comboCriptomonedas";
            this.comboCriptomonedas.Size = new System.Drawing.Size(117, 21);
            this.comboCriptomonedas.TabIndex = 21;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(211, 69);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(110, 20);
            this.textBoxCantidad.TabIndex = 22;
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
            this.btnAgregarCompra.Location = new System.Drawing.Point(287, 94);
            this.btnAgregarCompra.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarCompra.Name = "btnAgregarCompra";
            this.btnAgregarCompra.Size = new System.Drawing.Size(132, 27);
            this.btnAgregarCompra.TabIndex = 23;
            this.btnAgregarCompra.Text = "AGREGAR";
            this.btnAgregarCompra.TextColor = System.Drawing.Color.White;
            this.btnAgregarCompra.UseVisualStyleBackColor = false;
            this.btnAgregarCompra.Click += new System.EventHandler(this.btnAgregarCompra_Click);
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.White;
            this.iconPictureBox4.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.iconPictureBox4.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 31;
            this.iconPictureBox4.Location = new System.Drawing.Point(17, 63);
            this.iconPictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(31, 32);
            this.iconPictureBox4.TabIndex = 45;
            this.iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.iconPictureBox1.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 31;
            this.iconPictureBox1.Location = new System.Drawing.Point(175, 63);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(31, 32);
            this.iconPictureBox1.TabIndex = 46;
            this.iconPictureBox1.TabStop = false;
            // 
            // ABM_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMinimizarPantalla);
            this.Controls.Add(this.btnCerrarPantalla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ABM_Compra";
            this.Text = "ABM_Compra";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCripto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCerrarPantalla;
        private FontAwesome.Sharp.IconButton btnMinimizarPantalla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DataGridView grillaCripto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cripno_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Label labelNombreCripto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.ComboBox comboCriptomonedas;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJButton btnAgregarCompra;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
    }
}