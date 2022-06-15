namespace Criptomonedas.Formularios_Ventanas_.Listados
{
    partial class InformeClientes
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
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProyecto = new Criptomonedas.DataSetProyecto();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new RJCodeAdvance.RJControls.RJButton();
            this.panelRd = new System.Windows.Forms.Panel();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.rdBtnFiltrarFechaAlta = new System.Windows.Forms.RadioButton();
            this.textBoxFiltroMail = new System.Windows.Forms.TextBox();
            this.textBoxFiltroNombre = new System.Windows.Forms.TextBox();
            this.rdBtnFiltrarPorMail = new System.Windows.Forms.RadioButton();
            this.rdBtnFiltrarPorNombre = new System.Windows.Forms.RadioButton();
            this.rdBtnTodosClientes = new System.Windows.Forms.RadioButton();
            this.lblModificar = new System.Windows.Forms.Label();
            this.btnCerrarPantallaABMCliente = new FontAwesome.Sharp.IconButton();
            this.btnMinimizarPantallaABMCLiente = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewerClientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clientesTableAdapter = new Criptomonedas.DataSetProyectoTableAdapters.ClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProyecto)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelRd.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dataSetProyecto;
            // 
            // dataSetProyecto
            // 
            this.dataSetProyecto.DataSetName = "DataSetProyecto";
            this.dataSetProyecto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpFechaHasta);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.panelRd);
            this.panel1.Controls.Add(this.lblModificar);
            this.panel1.Controls.Add(this.btnCerrarPantallaABMCliente);
            this.panel1.Controls.Add(this.btnMinimizarPantallaABMCLiente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 143);
            this.panel1.TabIndex = 73;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(385, 115);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 7;
            this.dtpFechaHasta.Visible = false;
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
            this.btnConsultar.Location = new System.Drawing.Point(674, 43);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(91, 27);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // panelRd
            // 
            this.panelRd.Controls.Add(this.dtpFechaDesde);
            this.panelRd.Controls.Add(this.rdBtnFiltrarFechaAlta);
            this.panelRd.Controls.Add(this.textBoxFiltroMail);
            this.panelRd.Controls.Add(this.textBoxFiltroNombre);
            this.panelRd.Controls.Add(this.rdBtnFiltrarPorMail);
            this.panelRd.Controls.Add(this.rdBtnFiltrarPorNombre);
            this.panelRd.Controls.Add(this.rdBtnTodosClientes);
            this.panelRd.Location = new System.Drawing.Point(7, 43);
            this.panelRd.Name = "panelRd";
            this.panelRd.Size = new System.Drawing.Size(588, 94);
            this.panelRd.TabIndex = 72;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(172, 72);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 6;
            this.dtpFechaDesde.Visible = false;
            // 
            // rdBtnFiltrarFechaAlta
            // 
            this.rdBtnFiltrarFechaAlta.AutoSize = true;
            this.rdBtnFiltrarFechaAlta.Location = new System.Drawing.Point(3, 72);
            this.rdBtnFiltrarFechaAlta.Name = "rdBtnFiltrarFechaAlta";
            this.rdBtnFiltrarFechaAlta.Size = new System.Drawing.Size(133, 17);
            this.rdBtnFiltrarFechaAlta.TabIndex = 5;
            this.rdBtnFiltrarFechaAlta.TabStop = true;
            this.rdBtnFiltrarFechaAlta.Text = "Filtrar por fecha de alta";
            this.rdBtnFiltrarFechaAlta.UseVisualStyleBackColor = true;
            this.rdBtnFiltrarFechaAlta.CheckedChanged += new System.EventHandler(this.rdBtnFiltrarFechaAlta_CheckedChanged);
            // 
            // textBoxFiltroMail
            // 
            this.textBoxFiltroMail.Location = new System.Drawing.Point(172, 48);
            this.textBoxFiltroMail.Name = "textBoxFiltroMail";
            this.textBoxFiltroMail.Size = new System.Drawing.Size(147, 20);
            this.textBoxFiltroMail.TabIndex = 4;
            this.textBoxFiltroMail.Visible = false;
            // 
            // textBoxFiltroNombre
            // 
            this.textBoxFiltroNombre.Location = new System.Drawing.Point(172, 26);
            this.textBoxFiltroNombre.Name = "textBoxFiltroNombre";
            this.textBoxFiltroNombre.Size = new System.Drawing.Size(147, 20);
            this.textBoxFiltroNombre.TabIndex = 3;
            this.textBoxFiltroNombre.Visible = false;
            // 
            // rdBtnFiltrarPorMail
            // 
            this.rdBtnFiltrarPorMail.AutoSize = true;
            this.rdBtnFiltrarPorMail.Location = new System.Drawing.Point(3, 49);
            this.rdBtnFiltrarPorMail.Name = "rdBtnFiltrarPorMail";
            this.rdBtnFiltrarPorMail.Size = new System.Drawing.Size(89, 17);
            this.rdBtnFiltrarPorMail.TabIndex = 2;
            this.rdBtnFiltrarPorMail.TabStop = true;
            this.rdBtnFiltrarPorMail.Text = "Filtrar por mail";
            this.rdBtnFiltrarPorMail.UseVisualStyleBackColor = true;
            this.rdBtnFiltrarPorMail.CheckedChanged += new System.EventHandler(this.rdBtnFiltrarPorMail_CheckedChanged);
            // 
            // rdBtnFiltrarPorNombre
            // 
            this.rdBtnFiltrarPorNombre.AutoSize = true;
            this.rdBtnFiltrarPorNombre.Location = new System.Drawing.Point(3, 26);
            this.rdBtnFiltrarPorNombre.Name = "rdBtnFiltrarPorNombre";
            this.rdBtnFiltrarPorNombre.Size = new System.Drawing.Size(162, 17);
            this.rdBtnFiltrarPorNombre.TabIndex = 1;
            this.rdBtnFiltrarPorNombre.TabStop = true;
            this.rdBtnFiltrarPorNombre.Text = "Filtrado por nombre y apellido";
            this.rdBtnFiltrarPorNombre.UseVisualStyleBackColor = true;
            this.rdBtnFiltrarPorNombre.CheckedChanged += new System.EventHandler(this.rdBtnFiltrarPorNombre_CheckedChanged);
            // 
            // rdBtnTodosClientes
            // 
            this.rdBtnTodosClientes.AutoSize = true;
            this.rdBtnTodosClientes.Location = new System.Drawing.Point(3, 3);
            this.rdBtnTodosClientes.Name = "rdBtnTodosClientes";
            this.rdBtnTodosClientes.Size = new System.Drawing.Size(110, 17);
            this.rdBtnTodosClientes.TabIndex = 0;
            this.rdBtnTodosClientes.TabStop = true;
            this.rdBtnTodosClientes.Text = "Todos los clientes";
            this.rdBtnTodosClientes.UseVisualStyleBackColor = true;
            this.rdBtnTodosClientes.CheckedChanged += new System.EventHandler(this.rdBtnTodosClientes_CheckedChanged);
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Font = new System.Drawing.Font("Bauhaus 93", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblModificar.Location = new System.Drawing.Point(2, 9);
            this.lblModificar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(270, 30);
            this.lblModificar.TabIndex = 17;
            this.lblModificar.Text = "Informe de Clientes";
            // 
            // btnCerrarPantallaABMCliente
            // 
            this.btnCerrarPantallaABMCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarPantallaABMCliente.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCerrarPantallaABMCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrarPantallaABMCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarPantallaABMCliente.FlatAppearance.BorderSize = 0;
            this.btnCerrarPantallaABMCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPantallaABMCliente.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrarPantallaABMCliente.IconColor = System.Drawing.SystemColors.Control;
            this.btnCerrarPantallaABMCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarPantallaABMCliente.IconSize = 30;
            this.btnCerrarPantallaABMCliente.Location = new System.Drawing.Point(765, 1);
            this.btnCerrarPantallaABMCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarPantallaABMCliente.Name = "btnCerrarPantallaABMCliente";
            this.btnCerrarPantallaABMCliente.Size = new System.Drawing.Size(34, 20);
            this.btnCerrarPantallaABMCliente.TabIndex = 70;
            this.btnCerrarPantallaABMCliente.UseVisualStyleBackColor = false;
            this.btnCerrarPantallaABMCliente.Click += new System.EventHandler(this.btnCerrarPantallaABMCliente_Click);
            // 
            // btnMinimizarPantallaABMCLiente
            // 
            this.btnMinimizarPantallaABMCLiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizarPantallaABMCLiente.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMinimizarPantallaABMCLiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimizarPantallaABMCLiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarPantallaABMCLiente.FlatAppearance.BorderSize = 0;
            this.btnMinimizarPantallaABMCLiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarPantallaABMCLiente.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizarPantallaABMCLiente.IconColor = System.Drawing.SystemColors.Control;
            this.btnMinimizarPantallaABMCLiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizarPantallaABMCLiente.IconSize = 20;
            this.btnMinimizarPantallaABMCLiente.Location = new System.Drawing.Point(731, 1);
            this.btnMinimizarPantallaABMCLiente.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizarPantallaABMCLiente.Name = "btnMinimizarPantallaABMCLiente";
            this.btnMinimizarPantallaABMCLiente.Size = new System.Drawing.Size(34, 20);
            this.btnMinimizarPantallaABMCLiente.TabIndex = 71;
            this.btnMinimizarPantallaABMCLiente.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewerClientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 415);
            this.panel2.TabIndex = 74;
            // 
            // reportViewerClientes
            // 
            this.reportViewerClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetClientes";
            reportDataSource1.Value = this.clientesBindingSource;
            this.reportViewerClientes.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerClientes.LocalReport.ReportEmbeddedResource = "Criptomonedas.ListadoClientes.rdlc";
            this.reportViewerClientes.Location = new System.Drawing.Point(0, 0);
            this.reportViewerClientes.Name = "reportViewerClientes";
            this.reportViewerClientes.ServerReport.BearerToken = null;
            this.reportViewerClientes.Size = new System.Drawing.Size(800, 415);
            this.reportViewerClientes.TabIndex = 0;
            this.reportViewerClientes.Load += new System.EventHandler(this.reportViewerClientes_Load);
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // InformeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformeClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformeClientes";
            this.Load += new System.EventHandler(this.InformeClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProyecto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelRd.ResumeLayout(false);
            this.panelRd.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnMinimizarPantallaABMCLiente;
        private FontAwesome.Sharp.IconButton btnCerrarPantallaABMCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblModificar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerClientes;
        private DataSetProyecto dataSetProyecto;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSetProyectoTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.Panel panelRd;
        private System.Windows.Forms.RadioButton rdBtnFiltrarPorNombre;
        private System.Windows.Forms.RadioButton rdBtnTodosClientes;
        private System.Windows.Forms.RadioButton rdBtnFiltrarPorMail;
        private RJCodeAdvance.RJControls.RJButton btnConsultar;
        private System.Windows.Forms.TextBox textBoxFiltroMail;
        private System.Windows.Forms.TextBox textBoxFiltroNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.RadioButton rdBtnFiltrarFechaAlta;
    }
}