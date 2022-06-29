namespace Criptomonedas.Formularios_Ventanas_.Listados.Listado_Cotizaciones
{
    partial class ReporteMenosCompras
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
            this.reportViewerCotizaciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerCotizaciones
            // 
            this.reportViewerCotizaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerCotizaciones.LocalReport.ReportEmbeddedResource = "Criptomonedas.EstadisticasCotizaciones.rdlc";
            this.reportViewerCotizaciones.Location = new System.Drawing.Point(0, 0);
            this.reportViewerCotizaciones.Name = "reportViewerCotizaciones";
            this.reportViewerCotizaciones.ServerReport.BearerToken = null;
            this.reportViewerCotizaciones.Size = new System.Drawing.Size(800, 450);
            this.reportViewerCotizaciones.TabIndex = 1;
            this.reportViewerCotizaciones.Load += new System.EventHandler(this.reportViewerCotizaciones_Load);
            // 
            // ReporteMenosCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerCotizaciones);
            this.Name = "ReporteMenosCompras";
            this.Text = "ReporteMenosCompras";
            this.Load += new System.EventHandler(this.ReporteMenosCompras_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCotizaciones;
    }
}