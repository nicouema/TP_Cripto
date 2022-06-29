namespace Criptomonedas.Formularios_Ventanas_.Estadisticas.CompraVentaXCripto
{
    partial class CompraVentaXCripto
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
            this.lblABM_Barrio = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // lblABM_Barrio
            // 
            this.lblABM_Barrio.AutoSize = true;
            this.lblABM_Barrio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblABM_Barrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABM_Barrio.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblABM_Barrio.Location = new System.Drawing.Point(13, 68);
            this.lblABM_Barrio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblABM_Barrio.Name = "lblABM_Barrio";
            this.lblABM_Barrio.Size = new System.Drawing.Size(1397, 73);
            this.lblABM_Barrio.TabIndex = 29;
            this.lblABM_Barrio.Text = "Cantidad De Transacciones por Criptomoneda";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Criptomonedas.EstadisticaCompraVentaxCripto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 230);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1470, 544);
            this.reportViewer1.TabIndex = 30;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // CompraVentaXCripto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 798);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblABM_Barrio);
            this.Name = "CompraVentaXCripto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transacciones por Criptomoneda";
            this.Load += new System.EventHandler(this.CompraVentaXCripto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblABM_Barrio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}