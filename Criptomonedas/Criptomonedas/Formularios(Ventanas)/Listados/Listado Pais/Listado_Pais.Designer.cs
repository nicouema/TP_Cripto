namespace Criptomonedas
{
    partial class Listado_Pais
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.lblListadoPaises = new System.Windows.Forms.Label();
            this.ButtonBuscar = new RJCodeAdvance.RJControls.RJButton();
            this.btnCerrarPantallaReg = new FontAwesome.Sharp.IconButton();
            this.btnMinimizarPantallaReg = new FontAwesome.Sharp.IconButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.radioTodosPaises = new System.Windows.Forms.RadioButton();
            this.radioRangoIdentificador = new System.Windows.Forms.RadioButton();
            this.textRangoInicial = new System.Windows.Forms.TextBox();
            this.lblRangoInicial = new System.Windows.Forms.Label();
            this.lblRangoFinal = new System.Windows.Forms.Label();
            this.textRangoFinal = new System.Windows.Forms.TextBox();
            this.dataSetProyecto = new Criptomonedas.DataSetProyecto();
            this.dataSetProyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paísBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paísTableAdapter = new Criptomonedas.DataSetProyectoTableAdapters.PaísTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProyecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProyectoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paísBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListadoPaises
            // 
            this.lblListadoPaises.AutoSize = true;
            this.lblListadoPaises.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblListadoPaises.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoPaises.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblListadoPaises.Location = new System.Drawing.Point(13, 9);
            this.lblListadoPaises.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListadoPaises.Name = "lblListadoPaises";
            this.lblListadoPaises.Size = new System.Drawing.Size(556, 73);
            this.lblListadoPaises.TabIndex = 28;
            this.lblListadoPaises.Text = "Listado de Paises";
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
            this.ButtonBuscar.Location = new System.Drawing.Point(1005, 173);
            this.ButtonBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonBuscar.Name = "ButtonBuscar";
            this.ButtonBuscar.Size = new System.Drawing.Size(182, 56);
            this.ButtonBuscar.TabIndex = 45;
            this.ButtonBuscar.Text = "BUSCAR";
            this.ButtonBuscar.TextColor = System.Drawing.Color.White;
            this.ButtonBuscar.UseVisualStyleBackColor = false;
            this.ButtonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
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
            this.btnCerrarPantallaReg.Location = new System.Drawing.Point(1260, -2);
            this.btnCerrarPantallaReg.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarPantallaReg.Name = "btnCerrarPantallaReg";
            this.btnCerrarPantallaReg.Size = new System.Drawing.Size(68, 38);
            this.btnCerrarPantallaReg.TabIndex = 47;
            this.btnCerrarPantallaReg.UseVisualStyleBackColor = false;
            this.btnCerrarPantallaReg.Click += new System.EventHandler(this.btnCerrarPantallaReg_Click);
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
            this.btnMinimizarPantallaReg.Location = new System.Drawing.Point(1192, -2);
            this.btnMinimizarPantallaReg.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizarPantallaReg.Name = "btnMinimizarPantallaReg";
            this.btnMinimizarPantallaReg.Size = new System.Drawing.Size(68, 38);
            this.btnMinimizarPantallaReg.TabIndex = 46;
            this.btnMinimizarPantallaReg.UseVisualStyleBackColor = false;
            this.btnMinimizarPantallaReg.Click += new System.EventHandler(this.btnMinimizarPantallaReg_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetPais";
            reportDataSource1.Value = this.paísBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Criptomonedas.Listado_Pais.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(26, 274);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1272, 773);
            this.reportViewer1.TabIndex = 48;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // radioTodosPaises
            // 
            this.radioTodosPaises.AutoSize = true;
            this.radioTodosPaises.Location = new System.Drawing.Point(63, 85);
            this.radioTodosPaises.Name = "radioTodosPaises";
            this.radioTodosPaises.Size = new System.Drawing.Size(208, 29);
            this.radioTodosPaises.TabIndex = 49;
            this.radioTodosPaises.TabStop = true;
            this.radioTodosPaises.Text = "Todos los Paises";
            this.radioTodosPaises.UseVisualStyleBackColor = true;
            this.radioTodosPaises.CheckedChanged += new System.EventHandler(this.radioTodosPaises_CheckedChanged);
            // 
            // radioRangoIdentificador
            // 
            this.radioRangoIdentificador.AutoSize = true;
            this.radioRangoIdentificador.Location = new System.Drawing.Point(63, 138);
            this.radioRangoIdentificador.Name = "radioRangoIdentificador";
            this.radioRangoIdentificador.Size = new System.Drawing.Size(373, 29);
            this.radioRangoIdentificador.TabIndex = 50;
            this.radioRangoIdentificador.TabStop = true;
            this.radioRangoIdentificador.Text = "Restringido por rango Identificador";
            this.radioRangoIdentificador.UseVisualStyleBackColor = true;
            this.radioRangoIdentificador.CheckedChanged += new System.EventHandler(this.radioRangoIdentificador_CheckedChanged);
            // 
            // textRangoInicial
            // 
            this.textRangoInicial.Location = new System.Drawing.Point(277, 201);
            this.textRangoInicial.Name = "textRangoInicial";
            this.textRangoInicial.Size = new System.Drawing.Size(100, 31);
            this.textRangoInicial.TabIndex = 51;
            // 
            // lblRangoInicial
            // 
            this.lblRangoInicial.AutoSize = true;
            this.lblRangoInicial.Location = new System.Drawing.Point(83, 204);
            this.lblRangoInicial.Name = "lblRangoInicial";
            this.lblRangoInicial.Size = new System.Drawing.Size(136, 25);
            this.lblRangoInicial.TabIndex = 52;
            this.lblRangoInicial.Text = "Rango Inicial";
            // 
            // lblRangoFinal
            // 
            this.lblRangoFinal.AutoSize = true;
            this.lblRangoFinal.Location = new System.Drawing.Point(543, 201);
            this.lblRangoFinal.Name = "lblRangoFinal";
            this.lblRangoFinal.Size = new System.Drawing.Size(128, 25);
            this.lblRangoFinal.TabIndex = 54;
            this.lblRangoFinal.Text = "Rango Final";
            // 
            // textRangoFinal
            // 
            this.textRangoFinal.Location = new System.Drawing.Point(762, 201);
            this.textRangoFinal.Name = "textRangoFinal";
            this.textRangoFinal.Size = new System.Drawing.Size(100, 31);
            this.textRangoFinal.TabIndex = 53;
            // 
            // dataSetProyecto
            // 
            this.dataSetProyecto.DataSetName = "DataSetProyecto";
            this.dataSetProyecto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetProyectoBindingSource
            // 
            this.dataSetProyectoBindingSource.DataSource = this.dataSetProyecto;
            this.dataSetProyectoBindingSource.Position = 0;
            // 
            // paísBindingSource
            // 
            this.paísBindingSource.DataMember = "País";
            this.paísBindingSource.DataSource = this.dataSetProyectoBindingSource;
            // 
            // paísTableAdapter
            // 
            this.paísTableAdapter.ClearBeforeFill = true;
            // 
            // Listado_Pais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 1083);
            this.Controls.Add(this.lblRangoFinal);
            this.Controls.Add(this.textRangoFinal);
            this.Controls.Add(this.lblRangoInicial);
            this.Controls.Add(this.textRangoInicial);
            this.Controls.Add(this.radioRangoIdentificador);
            this.Controls.Add(this.radioTodosPaises);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnCerrarPantallaReg);
            this.Controls.Add(this.btnMinimizarPantallaReg);
            this.Controls.Add(this.ButtonBuscar);
            this.Controls.Add(this.lblListadoPaises);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listado_Pais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Ejecutivo De Cuenta";
            this.Load += new System.EventHandler(this.Listado_EjecutivoDeCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProyecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProyectoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paísBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListadoPaises;
        private RJCodeAdvance.RJControls.RJButton ButtonBuscar;
        private FontAwesome.Sharp.IconButton btnCerrarPantallaReg;
        private FontAwesome.Sharp.IconButton btnMinimizarPantallaReg;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.RadioButton radioTodosPaises;
        private System.Windows.Forms.RadioButton radioRangoIdentificador;
        private System.Windows.Forms.TextBox textRangoInicial;
        private System.Windows.Forms.Label lblRangoInicial;
        private System.Windows.Forms.Label lblRangoFinal;
        private System.Windows.Forms.TextBox textRangoFinal;
        private DataSetProyecto dataSetProyecto;
        private System.Windows.Forms.BindingSource dataSetProyectoBindingSource;
        private System.Windows.Forms.BindingSource paísBindingSource;
        private DataSetProyectoTableAdapters.PaísTableAdapter paísTableAdapter;
    }
}