namespace Criptomonedas.Formularios_Ventanas_.Listados
{
    partial class ReporteListadoCriptomonedas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.criptomonedasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProyecto = new Criptomonedas.DataSetProyecto();
            this.reporteCriptomonedas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.btnConsultar = new RJCodeAdvance.RJControls.RJButton();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.criptomonedasTableAdapter = new Criptomonedas.DataSetProyectoTableAdapters.CriptomonedasTableAdapter();
            this.rbResCodigo = new System.Windows.Forms.RadioButton();
            this.lblRestriccion = new System.Windows.Forms.Label();
            this.txtRestriccion = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.criptomonedasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // criptomonedasBindingSource
            // 
            this.criptomonedasBindingSource.DataMember = "Criptomonedas";
            this.criptomonedasBindingSource.DataSource = this.dataSetProyecto;
            // 
            // dataSetProyecto
            // 
            this.dataSetProyecto.DataSetName = "DataSetProyecto";
            this.dataSetProyecto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteCriptomonedas
            // 
            reportDataSource1.Name = "DataSetCriptomonedas";
            reportDataSource1.Value = this.criptomonedasBindingSource;
            this.reporteCriptomonedas.LocalReport.DataSources.Add(reportDataSource1);
            this.reporteCriptomonedas.LocalReport.ReportEmbeddedResource = "Criptomonedas.ListadoCriptomonedas.rdlc";
            this.reporteCriptomonedas.Location = new System.Drawing.Point(1, 92);
            this.reporteCriptomonedas.Name = "reporteCriptomonedas";
            this.reporteCriptomonedas.ServerReport.BearerToken = null;
            this.reporteCriptomonedas.Size = new System.Drawing.Size(799, 358);
            this.reporteCriptomonedas.TabIndex = 0;
            this.reporteCriptomonedas.Load += new System.EventHandler(this.reporteCriptomonedas_Load);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboard.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.lblDashboard.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblDashboard.Location = new System.Drawing.Point(11, 9);
            this.lblDashboard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(304, 25);
            this.lblDashboard.TabIndex = 5;
            this.lblDashboard.Text = "Listado de Criptomonedas";
            this.lblDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnConsultar.Location = new System.Drawing.Point(698, 46);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(91, 27);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Location = new System.Drawing.Point(16, 46);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(143, 17);
            this.rbTodas.TabIndex = 7;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "Todas las criptomonedas";
            this.rbTodas.UseVisualStyleBackColor = true;
            this.rbTodas.CheckedChanged += new System.EventHandler(this.rbTodas_CheckedChanged);
            // 
            // criptomonedasTableAdapter
            // 
            this.criptomonedasTableAdapter.ClearBeforeFill = true;
            // 
            // rbResCodigo
            // 
            this.rbResCodigo.AutoSize = true;
            this.rbResCodigo.Location = new System.Drawing.Point(172, 46);
            this.rbResCodigo.Name = "rbResCodigo";
            this.rbResCodigo.Size = new System.Drawing.Size(131, 17);
            this.rbResCodigo.TabIndex = 8;
            this.rbResCodigo.TabStop = true;
            this.rbResCodigo.Text = "Restringido por codigo";
            this.rbResCodigo.UseVisualStyleBackColor = true;
            this.rbResCodigo.CheckedChanged += new System.EventHandler(this.rbResCodigo_CheckedChanged);
            // 
            // lblRestriccion
            // 
            this.lblRestriccion.AutoSize = true;
            this.lblRestriccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestriccion.Location = new System.Drawing.Point(427, 43);
            this.lblRestriccion.Name = "lblRestriccion";
            this.lblRestriccion.Size = new System.Drawing.Size(51, 20);
            this.lblRestriccion.TabIndex = 9;
            this.lblRestriccion.Text = "label1";
            this.lblRestriccion.Visible = false;
            // 
            // txtRestriccion
            // 
            this.txtRestriccion.Location = new System.Drawing.Point(543, 43);
            this.txtRestriccion.Name = "txtRestriccion";
            this.txtRestriccion.Size = new System.Drawing.Size(100, 20);
            this.txtRestriccion.TabIndex = 11;
            this.txtRestriccion.Visible = false;
            // 
            // ReporteListadoCriptomonedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRestriccion);
            this.Controls.Add(this.lblRestriccion);
            this.Controls.Add(this.rbResCodigo);
            this.Controls.Add(this.rbTodas);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.reporteCriptomonedas);
            this.Name = "ReporteListadoCriptomonedas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado criptomonedas";
            this.Load += new System.EventHandler(this.ReporteListadoCriptomonedas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.criptomonedasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProyecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporteCriptomonedas;
        private System.Windows.Forms.Label lblDashboard;
        private RJCodeAdvance.RJControls.RJButton btnConsultar;
        private System.Windows.Forms.RadioButton rbTodas;
        private DataSetProyecto dataSetProyecto;
        private System.Windows.Forms.BindingSource criptomonedasBindingSource;
        private DataSetProyectoTableAdapters.CriptomonedasTableAdapter criptomonedasTableAdapter;
        private System.Windows.Forms.RadioButton rbResCodigo;
        private System.Windows.Forms.Label lblRestriccion;
        private System.Windows.Forms.MaskedTextBox txtRestriccion;
    }
}