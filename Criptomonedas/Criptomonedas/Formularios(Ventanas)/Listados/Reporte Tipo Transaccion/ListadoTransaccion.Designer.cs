namespace Criptomonedas.Formularios_Ventanas_.Listados
{
    partial class ListadoTransaccion
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
            this.reportTpM = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblListadoTransaccion = new System.Windows.Forms.Label();
            this.btnMinimizarPantallaReg = new FontAwesome.Sharp.IconButton();
            this.btnCerrarPantallaReg = new FontAwesome.Sharp.IconButton();
            this.panelRd = new System.Windows.Forms.Panel();
            this.txtCodCripto = new System.Windows.Forms.TextBox();
            this.txtNroCliente = new System.Windows.Forms.TextBox();
            this.rdBtnFiltrarPorCodCripto = new System.Windows.Forms.RadioButton();
            this.rdBtnFiltrarPorNroCliente = new System.Windows.Forms.RadioButton();
            this.rdBtnTodasTransacciones = new System.Windows.Forms.RadioButton();
            this.btnConsultar = new RJCodeAdvance.RJControls.RJButton();
            this.txtTipoOperacion = new System.Windows.Forms.TextBox();
            this.rdBtnFiltrarPorTipoOp = new System.Windows.Forms.RadioButton();
            this.panelRd.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportTpM
            // 
            this.reportTpM.LocalReport.ReportEmbeddedResource = "Criptomonedas.ListadoTransaccionPorMoneda.rdlc";
            this.reportTpM.Location = new System.Drawing.Point(0, 145);
            this.reportTpM.Name = "reportTpM";
            this.reportTpM.ServerReport.BearerToken = null;
            this.reportTpM.Size = new System.Drawing.Size(800, 413);
            this.reportTpM.TabIndex = 0;
            // 
            // lblListadoTransaccion
            // 
            this.lblListadoTransaccion.AutoSize = true;
            this.lblListadoTransaccion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblListadoTransaccion.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoTransaccion.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblListadoTransaccion.Location = new System.Drawing.Point(11, 9);
            this.lblListadoTransaccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListadoTransaccion.Name = "lblListadoTransaccion";
            this.lblListadoTransaccion.Size = new System.Drawing.Size(505, 36);
            this.lblListadoTransaccion.TabIndex = 28;
            this.lblListadoTransaccion.Text = "Listado Transaccion por Moneda";
            // 
            // btnMinimizarPantallaReg
            // 
            this.btnMinimizarPantallaReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizarPantallaReg.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMinimizarPantallaReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimizarPantallaReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarPantallaReg.FlatAppearance.BorderSize = 0;
            this.btnMinimizarPantallaReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarPantallaReg.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizarPantallaReg.IconColor = System.Drawing.SystemColors.Control;
            this.btnMinimizarPantallaReg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizarPantallaReg.IconSize = 20;
            this.btnMinimizarPantallaReg.Location = new System.Drawing.Point(732, 0);
            this.btnMinimizarPantallaReg.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizarPantallaReg.Name = "btnMinimizarPantallaReg";
            this.btnMinimizarPantallaReg.Size = new System.Drawing.Size(34, 20);
            this.btnMinimizarPantallaReg.TabIndex = 30;
            this.btnMinimizarPantallaReg.UseVisualStyleBackColor = false;
            this.btnMinimizarPantallaReg.Click += new System.EventHandler(this.btnMinimizarPantallaReg_Click);
            // 
            // btnCerrarPantallaReg
            // 
            this.btnCerrarPantallaReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarPantallaReg.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCerrarPantallaReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrarPantallaReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarPantallaReg.FlatAppearance.BorderSize = 0;
            this.btnCerrarPantallaReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPantallaReg.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrarPantallaReg.IconColor = System.Drawing.SystemColors.Control;
            this.btnCerrarPantallaReg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarPantallaReg.IconSize = 30;
            this.btnCerrarPantallaReg.Location = new System.Drawing.Point(766, 0);
            this.btnCerrarPantallaReg.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarPantallaReg.Name = "btnCerrarPantallaReg";
            this.btnCerrarPantallaReg.Size = new System.Drawing.Size(34, 20);
            this.btnCerrarPantallaReg.TabIndex = 29;
            this.btnCerrarPantallaReg.UseVisualStyleBackColor = false;
            this.btnCerrarPantallaReg.Click += new System.EventHandler(this.btnCerrarPantallaReg_Click);
            // 
            // panelRd
            // 
            this.panelRd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRd.Controls.Add(this.txtTipoOperacion);
            this.panelRd.Controls.Add(this.rdBtnFiltrarPorTipoOp);
            this.panelRd.Controls.Add(this.txtCodCripto);
            this.panelRd.Controls.Add(this.txtNroCliente);
            this.panelRd.Controls.Add(this.rdBtnFiltrarPorCodCripto);
            this.panelRd.Controls.Add(this.rdBtnFiltrarPorNroCliente);
            this.panelRd.Controls.Add(this.rdBtnTodasTransacciones);
            this.panelRd.Location = new System.Drawing.Point(12, 45);
            this.panelRd.Name = "panelRd";
            this.panelRd.Size = new System.Drawing.Size(588, 94);
            this.panelRd.TabIndex = 74;
            // 
            // txtCodCripto
            // 
            this.txtCodCripto.Location = new System.Drawing.Point(172, 48);
            this.txtCodCripto.Name = "txtCodCripto";
            this.txtCodCripto.Size = new System.Drawing.Size(122, 20);
            this.txtCodCripto.TabIndex = 4;
            this.txtCodCripto.Visible = false;
            // 
            // txtNroCliente
            // 
            this.txtNroCliente.Location = new System.Drawing.Point(172, 26);
            this.txtNroCliente.Name = "txtNroCliente";
            this.txtNroCliente.Size = new System.Drawing.Size(122, 20);
            this.txtNroCliente.TabIndex = 3;
            this.txtNroCliente.Visible = false;
            // 
            // rdBtnFiltrarPorCodCripto
            // 
            this.rdBtnFiltrarPorCodCripto.AutoSize = true;
            this.rdBtnFiltrarPorCodCripto.Location = new System.Drawing.Point(3, 49);
            this.rdBtnFiltrarPorCodCripto.Name = "rdBtnFiltrarPorCodCripto";
            this.rdBtnFiltrarPorCodCripto.Size = new System.Drawing.Size(147, 17);
            this.rdBtnFiltrarPorCodCripto.TabIndex = 2;
            this.rdBtnFiltrarPorCodCripto.TabStop = true;
            this.rdBtnFiltrarPorCodCripto.Text = "Filtrar por codigo de cripto";
            this.rdBtnFiltrarPorCodCripto.UseVisualStyleBackColor = true;
            this.rdBtnFiltrarPorCodCripto.CheckedChanged += new System.EventHandler(this.rdBtnFiltrarPorCodCripto_CheckedChanged);
            // 
            // rdBtnFiltrarPorNroCliente
            // 
            this.rdBtnFiltrarPorNroCliente.AutoSize = true;
            this.rdBtnFiltrarPorNroCliente.Location = new System.Drawing.Point(3, 26);
            this.rdBtnFiltrarPorNroCliente.Name = "rdBtnFiltrarPorNroCliente";
            this.rdBtnFiltrarPorNroCliente.Size = new System.Drawing.Size(164, 17);
            this.rdBtnFiltrarPorNroCliente.TabIndex = 1;
            this.rdBtnFiltrarPorNroCliente.TabStop = true;
            this.rdBtnFiltrarPorNroCliente.Text = "Filtrado por numero de cliente";
            this.rdBtnFiltrarPorNroCliente.UseVisualStyleBackColor = true;
            this.rdBtnFiltrarPorNroCliente.CheckedChanged += new System.EventHandler(this.rdBtnFiltrarPorNroCliente_CheckedChanged);
            // 
            // rdBtnTodasTransacciones
            // 
            this.rdBtnTodasTransacciones.AutoSize = true;
            this.rdBtnTodasTransacciones.Location = new System.Drawing.Point(3, 3);
            this.rdBtnTodasTransacciones.Name = "rdBtnTodasTransacciones";
            this.rdBtnTodasTransacciones.Size = new System.Drawing.Size(140, 17);
            this.rdBtnTodasTransacciones.TabIndex = 0;
            this.rdBtnTodasTransacciones.TabStop = true;
            this.rdBtnTodasTransacciones.Text = "Todas las transacciones";
            this.rdBtnTodasTransacciones.UseVisualStyleBackColor = true;
            this.rdBtnTodasTransacciones.CheckedChanged += new System.EventHandler(this.rdBtnTodasTransacciones_CheckedChanged);
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
            this.btnConsultar.Location = new System.Drawing.Point(698, 45);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(91, 27);
            this.btnConsultar.TabIndex = 75;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtTipoOperacion
            // 
            this.txtTipoOperacion.Location = new System.Drawing.Point(172, 71);
            this.txtTipoOperacion.Name = "txtTipoOperacion";
            this.txtTipoOperacion.Size = new System.Drawing.Size(122, 20);
            this.txtTipoOperacion.TabIndex = 6;
            this.txtTipoOperacion.Visible = false;
            // 
            // rdBtnFiltrarPorTipoOp
            // 
            this.rdBtnFiltrarPorTipoOp.AutoSize = true;
            this.rdBtnFiltrarPorTipoOp.Location = new System.Drawing.Point(3, 72);
            this.rdBtnFiltrarPorTipoOp.Name = "rdBtnFiltrarPorTipoOp";
            this.rdBtnFiltrarPorTipoOp.Size = new System.Drawing.Size(153, 17);
            this.rdBtnFiltrarPorTipoOp.TabIndex = 5;
            this.rdBtnFiltrarPorTipoOp.TabStop = true;
            this.rdBtnFiltrarPorTipoOp.Text = "Filtrar por tipo de operacion";
            this.rdBtnFiltrarPorTipoOp.UseVisualStyleBackColor = true;
            this.rdBtnFiltrarPorTipoOp.CheckedChanged += new System.EventHandler(this.rdBtnFiltrarPorTipoOp_CheckedChanged);
            // 
            // ListadoTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.panelRd);
            this.Controls.Add(this.btnMinimizarPantallaReg);
            this.Controls.Add(this.btnCerrarPantallaReg);
            this.Controls.Add(this.lblListadoTransaccion);
            this.Controls.Add(this.reportTpM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoTransaccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Transacciones";
            this.Load += new System.EventHandler(this.ListadoTransaccionesPorMoneda_Load);
            this.panelRd.ResumeLayout(false);
            this.panelRd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportTpM;
        private System.Windows.Forms.Label lblListadoTransaccion;
        private FontAwesome.Sharp.IconButton btnMinimizarPantallaReg;
        private FontAwesome.Sharp.IconButton btnCerrarPantallaReg;
        private System.Windows.Forms.Panel panelRd;
        private System.Windows.Forms.TextBox txtCodCripto;
        private System.Windows.Forms.TextBox txtNroCliente;
        private System.Windows.Forms.RadioButton rdBtnFiltrarPorCodCripto;
        private System.Windows.Forms.RadioButton rdBtnFiltrarPorNroCliente;
        private System.Windows.Forms.RadioButton rdBtnTodasTransacciones;
        private RJCodeAdvance.RJControls.RJButton btnConsultar;
        private System.Windows.Forms.TextBox txtTipoOperacion;
        private System.Windows.Forms.RadioButton rdBtnFiltrarPorTipoOp;
    }
}