namespace Criptomonedas.Formularios_Ventanas_.Listados.ReporteCriptomoneda
{
    partial class EstadisticaCincoMasVendidas
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
            this.reporteCriptomonedas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reporteCriptomonedas
            // 
            this.reporteCriptomonedas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporteCriptomonedas.LocalReport.ReportEmbeddedResource = "Criptomonedas.EstadisticaCincoCriptosMasVendidas.rdlc";
            this.reporteCriptomonedas.Location = new System.Drawing.Point(0, 0);
            this.reporteCriptomonedas.Name = "reporteCriptomonedas";
            this.reporteCriptomonedas.ServerReport.BearerToken = null;
            this.reporteCriptomonedas.Size = new System.Drawing.Size(800, 450);
            this.reporteCriptomonedas.TabIndex = 0;
            this.reporteCriptomonedas.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // EstadisticaCincoMasVendidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reporteCriptomonedas);
            this.Name = "EstadisticaCincoMasVendidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadisticaCincoMasVendidas";
            this.Load += new System.EventHandler(this.EstadisticaCincoMasVendidas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporteCriptomonedas;
    }
}