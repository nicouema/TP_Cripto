namespace Criptomonedas.Formularios_Ventanas_.Listados.ReporteClientes
{
    partial class EstadisticaCliente
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
            this.reportViewerEstadisticaCliente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerEstadisticaCliente
            // 
            this.reportViewerEstadisticaCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerEstadisticaCliente.LocalReport.ReportEmbeddedResource = "Criptomonedas.EstadisticaClientes.rdlc";
            this.reportViewerEstadisticaCliente.Location = new System.Drawing.Point(0, 0);
            this.reportViewerEstadisticaCliente.Name = "reportViewerEstadisticaCliente";
            this.reportViewerEstadisticaCliente.ServerReport.BearerToken = null;
            this.reportViewerEstadisticaCliente.Size = new System.Drawing.Size(573, 413);
            this.reportViewerEstadisticaCliente.TabIndex = 0;
            this.reportViewerEstadisticaCliente.Load += new System.EventHandler(this.reportViewerEstadisticaCliente_Load);
            // 
            // EstadisticaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 413);
            this.Controls.Add(this.reportViewerEstadisticaCliente);
            this.Name = "EstadisticaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadistica Cliente";
            this.Load += new System.EventHandler(this.EstadisticaCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerEstadisticaCliente;
    }
}