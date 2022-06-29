namespace Criptomonedas.Formularios_Ventanas_.Listados.ReporteClientes
{
    partial class EstadisticaClienteXProvincia
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
            this.reporteClienteXProvincia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reporteClienteXProvincia
            // 
            this.reporteClienteXProvincia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporteClienteXProvincia.LocalReport.ReportEmbeddedResource = "Criptomonedas.EstadisticaClienteXProvincia.rdlc";
            this.reporteClienteXProvincia.Location = new System.Drawing.Point(0, 0);
            this.reporteClienteXProvincia.Name = "reporteClienteXProvincia";
            this.reporteClienteXProvincia.ServerReport.BearerToken = null;
            this.reporteClienteXProvincia.Size = new System.Drawing.Size(800, 450);
            this.reporteClienteXProvincia.TabIndex = 0;
            this.reporteClienteXProvincia.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // EstadisticaClienteXProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reporteClienteXProvincia);
            this.Name = "EstadisticaClienteXProvincia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadisticaClienteXProvincia";
            this.Load += new System.EventHandler(this.EstadisticaClienteXProvincia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporteClienteXProvincia;
    }
}