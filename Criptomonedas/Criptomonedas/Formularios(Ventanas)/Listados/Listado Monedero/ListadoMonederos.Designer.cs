namespace Criptomonedas
{
    partial class ListadoMonederos
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_Todos = new System.Windows.Forms.RadioButton();
            this.rb_Criptomonedas = new System.Windows.Forms.RadioButton();
            this.rb_CodCliente = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNroCliente = new System.Windows.Forms.TextBox();
            this.cmbCriptomonedas = new System.Windows.Forms.ComboBox();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.btnConsulta = new RJCodeAdvance.RJControls.RJButton();
            this.lblListado = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Criptomonedas.ListadoRestriccionesMonedero.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 178);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1047, 337);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rb_Todos);
            this.panel2.Controls.Add(this.rb_Criptomonedas);
            this.panel2.Controls.Add(this.rb_CodCliente);
            this.panel2.Location = new System.Drawing.Point(20, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 83);
            this.panel2.TabIndex = 51;
            // 
            // rb_Todos
            // 
            this.rb_Todos.AutoSize = true;
            this.rb_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Todos.Location = new System.Drawing.Point(4, 4);
            this.rb_Todos.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Todos.Name = "rb_Todos";
            this.rb_Todos.Size = new System.Drawing.Size(191, 24);
            this.rb_Todos.TabIndex = 6;
            this.rb_Todos.TabStop = true;
            this.rb_Todos.Text = "Todos los Monederos";
            this.rb_Todos.UseVisualStyleBackColor = true;
            // 
            // rb_Criptomonedas
            // 
            this.rb_Criptomonedas.AutoSize = true;
            this.rb_Criptomonedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Criptomonedas.Location = new System.Drawing.Point(4, 46);
            this.rb_Criptomonedas.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Criptomonedas.Name = "rb_Criptomonedas";
            this.rb_Criptomonedas.Size = new System.Drawing.Size(253, 24);
            this.rb_Criptomonedas.TabIndex = 5;
            this.rb_Criptomonedas.TabStop = true;
            this.rb_Criptomonedas.Text = "Restringido por Criptomoneda";
            this.rb_Criptomonedas.UseVisualStyleBackColor = true;
            this.rb_Criptomonedas.CheckedChanged += new System.EventHandler(this.rb_Criptomonedas_CheckedChanged);
            // 
            // rb_CodCliente
            // 
            this.rb_CodCliente.AutoSize = true;
            this.rb_CodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_CodCliente.Location = new System.Drawing.Point(279, 46);
            this.rb_CodCliente.Margin = new System.Windows.Forms.Padding(4);
            this.rb_CodCliente.Name = "rb_CodCliente";
            this.rb_CodCliente.Size = new System.Drawing.Size(258, 24);
            this.rb_CodCliente.TabIndex = 4;
            this.rb_CodCliente.TabStop = true;
            this.rb_CodCliente.Text = "Restringido por Código Cliente";
            this.rb_CodCliente.UseVisualStyleBackColor = true;
            this.rb_CodCliente.CheckedChanged += new System.EventHandler(this.rb_NroCliente_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNroCliente);
            this.panel1.Controls.Add(this.cmbCriptomonedas);
            this.panel1.Controls.Add(this.lblSeleccion);
            this.panel1.Location = new System.Drawing.Point(614, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 140);
            this.panel1.TabIndex = 50;
            // 
            // txtNroCliente
            // 
            this.txtNroCliente.Location = new System.Drawing.Point(74, 103);
            this.txtNroCliente.Name = "txtNroCliente";
            this.txtNroCliente.Size = new System.Drawing.Size(142, 22);
            this.txtNroCliente.TabIndex = 9;
            // 
            // cmbCriptomonedas
            // 
            this.cmbCriptomonedas.FormattingEnabled = true;
            this.cmbCriptomonedas.Location = new System.Drawing.Point(74, 57);
            this.cmbCriptomonedas.Name = "cmbCriptomonedas";
            this.cmbCriptomonedas.Size = new System.Drawing.Size(142, 24);
            this.cmbCriptomonedas.TabIndex = 8;
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
            this.btnConsulta.Location = new System.Drawing.Point(946, 103);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(121, 36);
            this.btnConsulta.TabIndex = 49;
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
            this.lblListado.Location = new System.Drawing.Point(12, 20);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(414, 46);
            this.lblListado.TabIndex = 48;
            this.lblListado.Text = "Listado de Monedero";
            // 
            // ListadoMonederos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ListadoMonederos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoMonederos";
            this.Load += new System.EventHandler(this.ListadoMonederos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rb_Todos;
        private System.Windows.Forms.RadioButton rb_Criptomonedas;
        private System.Windows.Forms.RadioButton rb_CodCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSeleccion;
        private RJCodeAdvance.RJControls.RJButton btnConsulta;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.ComboBox cmbCriptomonedas;
        private System.Windows.Forms.TextBox txtNroCliente;
    }
}