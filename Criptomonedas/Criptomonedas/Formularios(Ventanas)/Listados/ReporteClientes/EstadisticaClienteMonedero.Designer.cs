namespace Criptomonedas.Formularios_Ventanas_.Listados.ReporteClientes
{
    partial class EstadisticaClienteMonedero
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
            this.reportViewerEstadisticaClienteMonedero = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerEstadisticaClienteMonedero
            // 
            this.reportViewerEstadisticaClienteMonedero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerEstadisticaClienteMonedero.LocalReport.ReportEmbeddedResource = "Criptomonedas.EstadisticaClienteMonedero.rdlc";
            this.reportViewerEstadisticaClienteMonedero.Location = new System.Drawing.Point(0, 0);
            this.reportViewerEstadisticaClienteMonedero.Name = "reportViewerEstadisticaClienteMonedero";
            this.reportViewerEstadisticaClienteMonedero.ServerReport.BearerToken = null;
            this.reportViewerEstadisticaClienteMonedero.Size = new System.Drawing.Size(576, 450);
            this.reportViewerEstadisticaClienteMonedero.TabIndex = 0;
            this.reportViewerEstadisticaClienteMonedero.Load += new System.EventHandler(this.reportViewerEstadisticaClienteMonedero_Load);
            // 
            // EstadisticaClienteMonedero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.reportViewerEstadisticaClienteMonedero);
            this.Name = "EstadisticaClienteMonedero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadisticaClienteMonedero";
            this.Load += new System.EventHandler(this.EstadisticaClienteMonedero_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerEstadisticaClienteMonedero;
    }
}