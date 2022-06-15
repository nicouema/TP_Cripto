namespace Criptomonedas.Formularios_Ventanas_.Listados.Listado_Empresa
{
    partial class Listado_Empresas
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
            this.lblRangoFinal = new System.Windows.Forms.Label();
            this.textRangoFinal = new System.Windows.Forms.TextBox();
            this.lblRangoInicial = new System.Windows.Forms.Label();
            this.textRangoInicial = new System.Windows.Forms.TextBox();
            this.radioRangoIdentificador = new System.Windows.Forms.RadioButton();
            this.radioTodasEmpresas = new System.Windows.Forms.RadioButton();
            this.ButtonBuscar = new RJCodeAdvance.RJControls.RJButton();
            this.lblListadoPaises = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnCerrarPantallaReg = new FontAwesome.Sharp.IconButton();
            this.btnMinimizarPantallaReg = new FontAwesome.Sharp.IconButton();
            this.btnCerrarPantallaABMCliente = new FontAwesome.Sharp.IconButton();
            this.btnMinimizarPantallaABMCLiente = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblRangoFinal
            // 
            this.lblRangoFinal.AutoSize = true;
            this.lblRangoFinal.Location = new System.Drawing.Point(272, 116);
            this.lblRangoFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRangoFinal.Name = "lblRangoFinal";
            this.lblRangoFinal.Size = new System.Drawing.Size(64, 13);
            this.lblRangoFinal.TabIndex = 64;
            this.lblRangoFinal.Text = "Rango Final";
            // 
            // textRangoFinal
            // 
            this.textRangoFinal.Location = new System.Drawing.Point(381, 116);
            this.textRangoFinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textRangoFinal.Name = "textRangoFinal";
            this.textRangoFinal.Size = new System.Drawing.Size(52, 20);
            this.textRangoFinal.TabIndex = 63;
            // 
            // lblRangoInicial
            // 
            this.lblRangoInicial.AutoSize = true;
            this.lblRangoInicial.Location = new System.Drawing.Point(-94, 163);
            this.lblRangoInicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRangoInicial.Name = "lblRangoInicial";
            this.lblRangoInicial.Size = new System.Drawing.Size(69, 13);
            this.lblRangoInicial.TabIndex = 62;
            this.lblRangoInicial.Text = "Rango Inicial";
            // 
            // textRangoInicial
            // 
            this.textRangoInicial.Location = new System.Drawing.Point(138, 116);
            this.textRangoInicial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textRangoInicial.Name = "textRangoInicial";
            this.textRangoInicial.Size = new System.Drawing.Size(52, 20);
            this.textRangoInicial.TabIndex = 61;
            // 
            // radioRangoIdentificador
            // 
            this.radioRangoIdentificador.AutoSize = true;
            this.radioRangoIdentificador.Location = new System.Drawing.Point(32, 83);
            this.radioRangoIdentificador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioRangoIdentificador.Name = "radioRangoIdentificador";
            this.radioRangoIdentificador.Size = new System.Drawing.Size(187, 17);
            this.radioRangoIdentificador.TabIndex = 60;
            this.radioRangoIdentificador.TabStop = true;
            this.radioRangoIdentificador.Text = "Restringido por rango Identificador";
            this.radioRangoIdentificador.UseVisualStyleBackColor = true;
            this.radioRangoIdentificador.CheckedChanged += new System.EventHandler(this.radioRangoIdentificador_CheckedChanged);
            // 
            // radioTodasEmpresas
            // 
            this.radioTodasEmpresas.AutoSize = true;
            this.radioTodasEmpresas.Location = new System.Drawing.Point(32, 56);
            this.radioTodasEmpresas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioTodasEmpresas.Name = "radioTodasEmpresas";
            this.radioTodasEmpresas.Size = new System.Drawing.Size(120, 17);
            this.radioTodasEmpresas.TabIndex = 59;
            this.radioTodasEmpresas.TabStop = true;
            this.radioTodasEmpresas.Text = "Todas las Empresas";
            this.radioTodasEmpresas.UseVisualStyleBackColor = true;
            // 
            // ButtonBuscar
            // 
            this.ButtonBuscar.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ButtonBuscar.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.ButtonBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonBuscar.BorderRadius = 0;
            this.ButtonBuscar.BorderSize = 0;
            this.ButtonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBuscar.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBuscar.ForeColor = System.Drawing.Color.White;
            this.ButtonBuscar.Location = new System.Drawing.Point(460, 103);
            this.ButtonBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonBuscar.Name = "ButtonBuscar";
            this.ButtonBuscar.Size = new System.Drawing.Size(91, 29);
            this.ButtonBuscar.TabIndex = 56;
            this.ButtonBuscar.Text = "BUSCAR";
            this.ButtonBuscar.TextColor = System.Drawing.Color.White;
            this.ButtonBuscar.UseVisualStyleBackColor = false;
            this.ButtonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // lblListadoPaises
            // 
            this.lblListadoPaises.AutoSize = true;
            this.lblListadoPaises.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblListadoPaises.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoPaises.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblListadoPaises.Location = new System.Drawing.Point(0, 5);
            this.lblListadoPaises.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListadoPaises.Name = "lblListadoPaises";
            this.lblListadoPaises.Size = new System.Drawing.Size(337, 37);
            this.lblListadoPaises.TabIndex = 55;
            this.lblListadoPaises.Text = "Listado de Empresas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Rango Inicial";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Criptomonedas.Listado_Empresas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 151);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(748, 314);
            this.reportViewer1.TabIndex = 66;
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
            this.btnCerrarPantallaReg.Location = new System.Drawing.Point(726, -1);
            this.btnCerrarPantallaReg.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarPantallaReg.Name = "btnCerrarPantallaReg";
            this.btnCerrarPantallaReg.Size = new System.Drawing.Size(34, 20);
            this.btnCerrarPantallaReg.TabIndex = 58;
            this.btnCerrarPantallaReg.UseVisualStyleBackColor = false;
            this.btnCerrarPantallaReg.Click += new System.EventHandler(this.btnCerrarPantallaReg_Click_1);
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
            this.btnMinimizarPantallaReg.Location = new System.Drawing.Point(692, -1);
            this.btnMinimizarPantallaReg.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizarPantallaReg.Name = "btnMinimizarPantallaReg";
            this.btnMinimizarPantallaReg.Size = new System.Drawing.Size(34, 20);
            this.btnMinimizarPantallaReg.TabIndex = 57;
            this.btnMinimizarPantallaReg.UseVisualStyleBackColor = false;
            this.btnMinimizarPantallaReg.Click += new System.EventHandler(this.btnMinimizarPantallaReg_Click_1);
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
            this.btnCerrarPantallaABMCliente.Location = new System.Drawing.Point(658, 1);
            this.btnCerrarPantallaABMCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarPantallaABMCliente.Name = "btnCerrarPantallaABMCliente";
            this.btnCerrarPantallaABMCliente.Size = new System.Drawing.Size(34, 20);
            this.btnCerrarPantallaABMCliente.TabIndex = 72;
            this.btnCerrarPantallaABMCliente.UseVisualStyleBackColor = false;
            this.btnCerrarPantallaABMCliente.Click += new System.EventHandler(this.btnCerrarPantallaABMCliente_Click);
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
            this.btnMinimizarPantallaABMCLiente.Location = new System.Drawing.Point(624, 1);
            this.btnMinimizarPantallaABMCLiente.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizarPantallaABMCLiente.Name = "btnMinimizarPantallaABMCLiente";
            this.btnMinimizarPantallaABMCLiente.Size = new System.Drawing.Size(34, 20);
            this.btnMinimizarPantallaABMCLiente.TabIndex = 73;
            this.btnMinimizarPantallaABMCLiente.UseVisualStyleBackColor = false;
            // 
            // Listado_Empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 410);
            this.Controls.Add(this.btnCerrarPantallaABMCliente);
            this.Controls.Add(this.btnMinimizarPantallaABMCLiente);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRangoFinal);
            this.Controls.Add(this.textRangoFinal);
            this.Controls.Add(this.lblRangoInicial);
            this.Controls.Add(this.textRangoInicial);
            this.Controls.Add(this.radioRangoIdentificador);
            this.Controls.Add(this.radioTodasEmpresas);
            this.Controls.Add(this.btnCerrarPantallaReg);
            this.Controls.Add(this.btnMinimizarPantallaReg);
            this.Controls.Add(this.ButtonBuscar);
            this.Controls.Add(this.lblListadoPaises);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Listado_Empresas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado_Empresas";
            this.Load += new System.EventHandler(this.Listado_Empresas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRangoFinal;
        private System.Windows.Forms.TextBox textRangoFinal;
        private System.Windows.Forms.Label lblRangoInicial;
        private System.Windows.Forms.TextBox textRangoInicial;
        private System.Windows.Forms.RadioButton radioRangoIdentificador;
        private System.Windows.Forms.RadioButton radioTodasEmpresas;
        private FontAwesome.Sharp.IconButton btnCerrarPantallaReg;
        private FontAwesome.Sharp.IconButton btnMinimizarPantallaReg;
        private RJCodeAdvance.RJControls.RJButton ButtonBuscar;
        private System.Windows.Forms.Label lblListadoPaises;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FontAwesome.Sharp.IconButton btnCerrarPantallaABMCliente;
        private FontAwesome.Sharp.IconButton btnMinimizarPantallaABMCLiente;
    }
}