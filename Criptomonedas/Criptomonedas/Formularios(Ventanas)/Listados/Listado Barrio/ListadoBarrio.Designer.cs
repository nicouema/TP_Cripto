namespace Criptomonedas.Formularios_Ventanas_.Listados.Listado_Barrio
{
    partial class ListadoBarrio
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbFiltrarCiudad = new System.Windows.Forms.RadioButton();
            this.btnConsulta = new RJCodeAdvance.RJControls.RJButton();
            this.lblListado = new System.Windows.Forms.Label();
            this.reportViewerBarrios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxCiudad);
            this.panel2.Controls.Add(this.rbTodos);
            this.panel2.Controls.Add(this.rbFiltrarCiudad);
            this.panel2.Location = new System.Drawing.Point(11, 45);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 57);
            this.panel2.TabIndex = 52;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.Location = new System.Drawing.Point(4, 3);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(136, 21);
            this.rbTodos.TabIndex = 6;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos los barrios";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // rbFiltrarCiudad
            // 
            this.rbFiltrarCiudad.AutoSize = true;
            this.rbFiltrarCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFiltrarCiudad.Location = new System.Drawing.Point(4, 27);
            this.rbFiltrarCiudad.Name = "rbFiltrarCiudad";
            this.rbFiltrarCiudad.Size = new System.Drawing.Size(135, 21);
            this.rbFiltrarCiudad.TabIndex = 5;
            this.rbFiltrarCiudad.TabStop = true;
            this.rbFiltrarCiudad.Text = "Filtrar por Ciudad";
            this.rbFiltrarCiudad.UseVisualStyleBackColor = true;
            this.rbFiltrarCiudad.CheckedChanged += new System.EventHandler(this.rbFiltrarCiudad_CheckedChanged);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnConsulta.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.btnConsulta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConsulta.BorderRadius = 0;
            this.btnConsulta.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Location = new System.Drawing.Point(683, 48);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(114, 29);
            this.btnConsulta.TabIndex = 50;
            this.btnConsulta.Text = "BUSCAR";
            this.btnConsulta.TextColor = System.Drawing.Color.White;
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblListado.Location = new System.Drawing.Point(5, 5);
            this.lblListado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(294, 37);
            this.lblListado.TabIndex = 49;
            this.lblListado.Text = "Listado de Barrios";
            // 
            // reportViewerBarrios
            // 
            this.reportViewerBarrios.LocalReport.ReportEmbeddedResource = "Criptomonedas.ReportBarrios.rdlc";
            this.reportViewerBarrios.Location = new System.Drawing.Point(5, 106);
            this.reportViewerBarrios.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewerBarrios.Name = "reportViewerBarrios";
            this.reportViewerBarrios.ServerReport.BearerToken = null;
            this.reportViewerBarrios.Size = new System.Drawing.Size(792, 493);
            this.reportViewerBarrios.TabIndex = 48;
            this.reportViewerBarrios.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(188, 28);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(171, 20);
            this.textBoxCiudad.TabIndex = 8;
            // 
            // ListadoBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 588);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.reportViewerBarrios);
            this.Name = "ListadoBarrio";
            this.Text = "ListadoBarrio";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbFiltrarCiudad;
        private RJCodeAdvance.RJControls.RJButton btnConsulta;
        private System.Windows.Forms.Label lblListado;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBarrios;
        private System.Windows.Forms.TextBox textBoxCiudad;
    }
}