namespace Criptomonedas.Formularios_Ventanas_.Listados.ReporteCriptomoneda
{
    partial class ReporteMenosVendidas
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
            this.reportViewerVentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerVentas
            // 
            this.reportViewerVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerVentas.LocalReport.ReportEmbeddedResource = "Criptomonedas.EstadisticaCincoCriptosMenosVendidas.rdlc";
            this.reportViewerVentas.Location = new System.Drawing.Point(0, 0);
            this.reportViewerVentas.Name = "reportViewerVentas";
            this.reportViewerVentas.ServerReport.BearerToken = null;
            this.reportViewerVentas.Size = new System.Drawing.Size(800, 450);
            this.reportViewerVentas.TabIndex = 2;
            // 
            // ReporteMenosVendidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerVentas);
            this.Name = "ReporteMenosVendidas";
            this.Text = "ReporteMenosVendidas";
            this.Load += new System.EventHandler(this.ReporteMenosVendidas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerVentas;
    }
}