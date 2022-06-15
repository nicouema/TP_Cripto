namespace Criptomonedas.Formularios_Ventanas_.ReporteAreaTel
{
    partial class ReporteListadoAreaTelefonica
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
            this.txtRestriccion = new System.Windows.Forms.MaskedTextBox();
            this.lblRestriccion = new System.Windows.Forms.Label();
            this.rbResArea = new System.Windows.Forms.RadioButton();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.btnConsultar = new RJCodeAdvance.RJControls.RJButton();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.reporteCriptomonedas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // txtRestriccion
            // 
            this.txtRestriccion.Location = new System.Drawing.Point(536, 39);
            this.txtRestriccion.Name = "txtRestriccion";
            this.txtRestriccion.Size = new System.Drawing.Size(100, 20);
            this.txtRestriccion.TabIndex = 18;
            this.txtRestriccion.Visible = false;
            // 
            // lblRestriccion
            // 
            this.lblRestriccion.AutoSize = true;
            this.lblRestriccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestriccion.Location = new System.Drawing.Point(412, 39);
            this.lblRestriccion.Name = "lblRestriccion";
            this.lblRestriccion.Size = new System.Drawing.Size(51, 20);
            this.lblRestriccion.TabIndex = 17;
            this.lblRestriccion.Text = "label1";
            this.lblRestriccion.Visible = false;
            // 
            // rbResArea
            // 
            this.rbResArea.AutoSize = true;
            this.rbResArea.Location = new System.Drawing.Point(172, 42);
            this.rbResArea.Name = "rbResArea";
            this.rbResArea.Size = new System.Drawing.Size(120, 17);
            this.rbResArea.TabIndex = 16;
            this.rbResArea.TabStop = true;
            this.rbResArea.Text = "Restringido por area";
            this.rbResArea.UseVisualStyleBackColor = true;
            this.rbResArea.CheckedChanged += new System.EventHandler(this.rbResArea_CheckedChanged);
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Location = new System.Drawing.Point(16, 42);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(100, 17);
            this.rbTodas.TabIndex = 15;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "Todas las areas";
            this.rbTodas.UseVisualStyleBackColor = true;
            this.rbTodas.CheckedChanged += new System.EventHandler(this.rbTodas_CheckedChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnConsultar.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.btnConsultar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConsultar.BorderRadius = 0;
            this.btnConsultar.BorderSize = 0;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(698, 42);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(91, 27);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboard.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.lblDashboard.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblDashboard.Location = new System.Drawing.Point(11, 5);
            this.lblDashboard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(333, 25);
            this.lblDashboard.TabIndex = 13;
            this.lblDashboard.Text = "Listado de Areas Telefonicas";
            this.lblDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reporteCriptomonedas
            // 
            this.reporteCriptomonedas.LocalReport.ReportEmbeddedResource = "Criptomonedas.ListadoAreaTelefonica.rdlc";
            this.reporteCriptomonedas.Location = new System.Drawing.Point(1, 88);
            this.reporteCriptomonedas.Name = "reporteCriptomonedas";
            this.reporteCriptomonedas.ServerReport.BearerToken = null;
            this.reporteCriptomonedas.Size = new System.Drawing.Size(799, 358);
            this.reporteCriptomonedas.TabIndex = 12;
            // 
            // ReporteListadoAreaTelefonica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRestriccion);
            this.Controls.Add(this.lblRestriccion);
            this.Controls.Add(this.rbResArea);
            this.Controls.Add(this.rbTodas);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.reporteCriptomonedas);
            this.Name = "ReporteListadoAreaTelefonica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteListadoAreaTelefonica";
            this.Load += new System.EventHandler(this.ReporteListadoAreaTelefonica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtRestriccion;
        private System.Windows.Forms.Label lblRestriccion;
        private System.Windows.Forms.RadioButton rbResArea;
        private System.Windows.Forms.RadioButton rbTodas;
        private RJCodeAdvance.RJControls.RJButton btnConsultar;
        private System.Windows.Forms.Label lblDashboard;
        private Microsoft.Reporting.WinForms.ReportViewer reporteCriptomonedas;
    }
}