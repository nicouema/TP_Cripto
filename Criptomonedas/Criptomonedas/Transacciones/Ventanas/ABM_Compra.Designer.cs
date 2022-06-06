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
            this.comboCriptomonedas = new RJCodeAdvance.RJControls.RJComboBox();
            this.labelNombreCripto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCripto)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel3.Controls.Add(this.comboCriptomonedas);
            this.panel3.Controls.Add(this.labelNombreCripto);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(279, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(521, 417);
            this.panel3.TabIndex = 7;
            // 
            // comboCriptomonedas
            // 
            this.comboCriptomonedas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboCriptomonedas.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboCriptomonedas.BorderSize = 1;
            this.comboCriptomonedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboCriptomonedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboCriptomonedas.ForeColor = System.Drawing.Color.DimGray;
            this.comboCriptomonedas.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboCriptomonedas.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboCriptomonedas.ListTextColor = System.Drawing.Color.DimGray;
            this.comboCriptomonedas.Location = new System.Drawing.Point(89, 48);
            this.comboCriptomonedas.MinimumSize = new System.Drawing.Size(200, 20);
            this.comboCriptomonedas.Name = "comboCriptomonedas";
            this.comboCriptomonedas.Padding = new System.Windows.Forms.Padding(1);
            this.comboCriptomonedas.Size = new System.Drawing.Size(200, 20);
            this.comboCriptomonedas.TabIndex = 19;
            this.comboCriptomonedas.Texts = "";
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
        private RJCodeAdvance.RJControls.RJComboBox comboCriptomonedas;
        private System.Windows.Forms.Label labelNombreCripto;
        private System.Windows.Forms.Label label1;
    }
}