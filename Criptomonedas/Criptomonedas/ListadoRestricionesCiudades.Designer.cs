namespace Criptomonedas.Formularios_Ventanas_.Listados
{
    partial class ListadoRestriccionesCiudades
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rb_Provincia = new System.Windows.Forms.RadioButton();
            this.rb_País = new System.Windows.Forms.RadioButton();
            this.rb_Todos = new System.Windows.Forms.RadioButton();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.cbSeleccion = new System.Windows.Forms.ComboBox();
            this.lblListado = new System.Windows.Forms.Label();
            this.btnConsulta = new RJCodeAdvance.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Criptomonedas.ListadoRestriccionesCiudades.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 178);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1055, 561);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // rb_Provincia
            // 
            this.rb_Provincia.AutoSize = true;
            this.rb_Provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Provincia.Location = new System.Drawing.Point(279, 46);
            this.rb_Provincia.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Provincia.Name = "rb_Provincia";
            this.rb_Provincia.Size = new System.Drawing.Size(218, 24);
            this.rb_Provincia.TabIndex = 4;
            this.rb_Provincia.TabStop = true;
            this.rb_Provincia.Text = "Restringido por Provincia";
            this.rb_Provincia.UseVisualStyleBackColor = true;
            this.rb_Provincia.CheckedChanged += new System.EventHandler(this.rb_Provincia_CheckedChanged);
            // 
            // rb_País
            // 
            this.rb_País.AutoSize = true;
            this.rb_País.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_País.Location = new System.Drawing.Point(4, 46);
            this.rb_País.Margin = new System.Windows.Forms.Padding(4);
            this.rb_País.Name = "rb_País";
            this.rb_País.Size = new System.Drawing.Size(182, 24);
            this.rb_País.TabIndex = 5;
            this.rb_País.TabStop = true;
            this.rb_País.Text = "Restringido por País";
            this.rb_País.UseVisualStyleBackColor = true;
            this.rb_País.CheckedChanged += new System.EventHandler(this.rb_País_CheckedChanged);
            // 
            // rb_Todos
            // 
            this.rb_Todos.AutoSize = true;
            this.rb_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Todos.Location = new System.Drawing.Point(4, 4);
            this.rb_Todos.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Todos.Name = "rb_Todos";
            this.rb_Todos.Size = new System.Drawing.Size(178, 24);
            this.rb_Todos.TabIndex = 6;
            this.rb_Todos.TabStop = true;
            this.rb_Todos.Text = "Todos las Ciudades";
            this.rb_Todos.UseVisualStyleBackColor = true;
            this.rb_Todos.CheckedChanged += new System.EventHandler(this.rb_Todos_CheckedChanged_1);
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccion.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblSeleccion.Location = new System.Drawing.Point(117, 21);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(58, 25);
            this.lblSeleccion.TabIndex = 7;
            this.lblSeleccion.Text = "label";
            // 
            // cbSeleccion
            // 
            this.cbSeleccion.FormattingEnabled = true;
            this.cbSeleccion.Location = new System.Drawing.Point(92, 55);
            this.cbSeleccion.Name = "cbSeleccion";
            this.cbSeleccion.Size = new System.Drawing.Size(121, 24);
            this.cbSeleccion.TabIndex = 8;
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblListado.Location = new System.Drawing.Point(12, 9);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(402, 46);
            this.lblListado.TabIndex = 28;
            this.lblListado.Text = "Listado de Ciudades";
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
            this.btnConsulta.Location = new System.Drawing.Point(946, 92);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(121, 36);
            this.btnConsulta.TabIndex = 45;
            this.btnConsulta.Text = "BUSCAR";
            this.btnConsulta.TextColor = System.Drawing.Color.White;
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbSeleccion);
            this.panel1.Controls.Add(this.lblSeleccion);
            this.panel1.Location = new System.Drawing.Point(549, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 91);
            this.panel1.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rb_Todos);
            this.panel2.Controls.Add(this.rb_País);
            this.panel2.Controls.Add(this.rb_Provincia);
            this.panel2.Location = new System.Drawing.Point(20, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 83);
            this.panel2.TabIndex = 47;
            // 
            // ListadoRestriccionesCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 763);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ListadoRestriccionesCiudades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Restricciones de Ciudades";
            this.Load += new System.EventHandler(this.Listado_con_restriciones_de_Ciudades_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.RadioButton rb_Provincia;
        private System.Windows.Forms.RadioButton rb_País;
        private System.Windows.Forms.RadioButton rb_Todos;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.ComboBox cbSeleccion;
        private System.Windows.Forms.Label lblListado;
        private RJCodeAdvance.RJControls.RJButton btnConsulta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}