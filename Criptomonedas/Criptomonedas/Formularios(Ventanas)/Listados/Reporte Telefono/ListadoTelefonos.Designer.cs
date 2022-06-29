namespace Criptomonedas.Formularios_Ventanas_.Listados
{
    partial class ListadoTelefonos
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
            this.lblListadoTelefonos = new System.Windows.Forms.Label();
            this.reportTelefonos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnMinimizarPantallaReg = new FontAwesome.Sharp.IconButton();
            this.btnCerrarPantallaReg = new FontAwesome.Sharp.IconButton();
            this.panelRd = new System.Windows.Forms.Panel();
            this.rdBtnFiltrarNroCliente = new System.Windows.Forms.RadioButton();
            this.txtCodArea = new System.Windows.Forms.TextBox();
            this.txtCodPais = new System.Windows.Forms.TextBox();
            this.rdBtnFiltrarPorCodArea = new System.Windows.Forms.RadioButton();
            this.rdBtnFiltrarPorCodPais = new System.Windows.Forms.RadioButton();
            this.rdBtnTodosTelefonos = new System.Windows.Forms.RadioButton();
            this.btnConsultar = new RJCodeAdvance.RJControls.RJButton();
            this.txtNroCliente = new System.Windows.Forms.TextBox();
            this.panelRd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListadoTelefonos
            // 
            this.lblListadoTelefonos.AutoSize = true;
            this.lblListadoTelefonos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblListadoTelefonos.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoTelefonos.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblListadoTelefonos.Location = new System.Drawing.Point(11, 9);
            this.lblListadoTelefonos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListadoTelefonos.Name = "lblListadoTelefonos";
            this.lblListadoTelefonos.Size = new System.Drawing.Size(324, 36);
            this.lblListadoTelefonos.TabIndex = 29;
            this.lblListadoTelefonos.Text = "Listado de Telefonos";
            // 
            // reportTelefonos
            // 
            this.reportTelefonos.LocalReport.ReportEmbeddedResource = "Criptomonedas.ListadoTelefonos.rdlc";
            this.reportTelefonos.Location = new System.Drawing.Point(0, 148);
            this.reportTelefonos.Name = "reportTelefonos";
            this.reportTelefonos.ServerReport.BearerToken = null;
            this.reportTelefonos.Size = new System.Drawing.Size(800, 413);
            this.reportTelefonos.TabIndex = 33;
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
            this.btnMinimizarPantallaReg.Location = new System.Drawing.Point(732, -1);
            this.btnMinimizarPantallaReg.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizarPantallaReg.Name = "btnMinimizarPantallaReg";
            this.btnMinimizarPantallaReg.Size = new System.Drawing.Size(34, 20);
            this.btnMinimizarPantallaReg.TabIndex = 32;
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
            this.btnCerrarPantallaReg.Location = new System.Drawing.Point(766, -1);
            this.btnCerrarPantallaReg.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarPantallaReg.Name = "btnCerrarPantallaReg";
            this.btnCerrarPantallaReg.Size = new System.Drawing.Size(34, 20);
            this.btnCerrarPantallaReg.TabIndex = 31;
            this.btnCerrarPantallaReg.UseVisualStyleBackColor = false;
            this.btnCerrarPantallaReg.Click += new System.EventHandler(this.btnCerrarPantallaReg_Click);
            // 
            // panelRd
            // 
            this.panelRd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRd.Controls.Add(this.txtNroCliente);
            this.panelRd.Controls.Add(this.rdBtnFiltrarNroCliente);
            this.panelRd.Controls.Add(this.txtCodArea);
            this.panelRd.Controls.Add(this.txtCodPais);
            this.panelRd.Controls.Add(this.rdBtnFiltrarPorCodArea);
            this.panelRd.Controls.Add(this.rdBtnFiltrarPorCodPais);
            this.panelRd.Controls.Add(this.rdBtnTodosTelefonos);
            this.panelRd.Location = new System.Drawing.Point(17, 48);
            this.panelRd.Name = "panelRd";
            this.panelRd.Size = new System.Drawing.Size(588, 94);
            this.panelRd.TabIndex = 73;
            // 
            // rdBtnFiltrarNroCliente
            // 
            this.rdBtnFiltrarNroCliente.AutoSize = true;
            this.rdBtnFiltrarNroCliente.Location = new System.Drawing.Point(3, 72);
            this.rdBtnFiltrarNroCliente.Name = "rdBtnFiltrarNroCliente";
            this.rdBtnFiltrarNroCliente.Size = new System.Drawing.Size(155, 17);
            this.rdBtnFiltrarNroCliente.TabIndex = 5;
            this.rdBtnFiltrarNroCliente.TabStop = true;
            this.rdBtnFiltrarNroCliente.Text = "Filtrar por numero de cliente";
            this.rdBtnFiltrarNroCliente.UseVisualStyleBackColor = true;
            this.rdBtnFiltrarNroCliente.CheckedChanged += new System.EventHandler(this.rdBtnFiltrarNroCliente_CheckedChanged);
            // 
            // txtCodArea
            // 
            this.txtCodArea.Location = new System.Drawing.Point(172, 48);
            this.txtCodArea.Name = "txtCodArea";
            this.txtCodArea.Size = new System.Drawing.Size(147, 20);
            this.txtCodArea.TabIndex = 4;
            this.txtCodArea.Visible = false;
            // 
            // txtCodPais
            // 
            this.txtCodPais.Location = new System.Drawing.Point(172, 26);
            this.txtCodPais.Name = "txtCodPais";
            this.txtCodPais.Size = new System.Drawing.Size(147, 20);
            this.txtCodPais.TabIndex = 3;
            this.txtCodPais.Visible = false;
            // 
            // rdBtnFiltrarPorCodArea
            // 
            this.rdBtnFiltrarPorCodArea.AutoSize = true;
            this.rdBtnFiltrarPorCodArea.Location = new System.Drawing.Point(3, 49);
            this.rdBtnFiltrarPorCodArea.Name = "rdBtnFiltrarPorCodArea";
            this.rdBtnFiltrarPorCodArea.Size = new System.Drawing.Size(142, 17);
            this.rdBtnFiltrarPorCodArea.TabIndex = 2;
            this.rdBtnFiltrarPorCodArea.TabStop = true;
            this.rdBtnFiltrarPorCodArea.Text = "Filtrar por codigo de area";
            this.rdBtnFiltrarPorCodArea.UseVisualStyleBackColor = true;
            this.rdBtnFiltrarPorCodArea.CheckedChanged += new System.EventHandler(this.rdBtnFiltrarPorCodArea_CheckedChanged);
            // 
            // rdBtnFiltrarPorCodPais
            // 
            this.rdBtnFiltrarPorCodPais.AutoSize = true;
            this.rdBtnFiltrarPorCodPais.Location = new System.Drawing.Point(3, 26);
            this.rdBtnFiltrarPorCodPais.Name = "rdBtnFiltrarPorCodPais";
            this.rdBtnFiltrarPorCodPais.Size = new System.Drawing.Size(149, 17);
            this.rdBtnFiltrarPorCodPais.TabIndex = 1;
            this.rdBtnFiltrarPorCodPais.TabStop = true;
            this.rdBtnFiltrarPorCodPais.Text = "Filtrado por codigo de pais";
            this.rdBtnFiltrarPorCodPais.UseVisualStyleBackColor = true;
            this.rdBtnFiltrarPorCodPais.CheckedChanged += new System.EventHandler(this.rdBtnFiltrarPorCodPais_CheckedChanged);
            // 
            // rdBtnTodosTelefonos
            // 
            this.rdBtnTodosTelefonos.AutoSize = true;
            this.rdBtnTodosTelefonos.Location = new System.Drawing.Point(3, 3);
            this.rdBtnTodosTelefonos.Name = "rdBtnTodosTelefonos";
            this.rdBtnTodosTelefonos.Size = new System.Drawing.Size(117, 17);
            this.rdBtnTodosTelefonos.TabIndex = 0;
            this.rdBtnTodosTelefonos.TabStop = true;
            this.rdBtnTodosTelefonos.Text = "Todos los telefonos";
            this.rdBtnTodosTelefonos.UseVisualStyleBackColor = true;
            this.rdBtnTodosTelefonos.CheckedChanged += new System.EventHandler(this.rdBtnTodosTelefonos_CheckedChanged);
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
            this.btnConsultar.Location = new System.Drawing.Point(698, 48);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(91, 27);
            this.btnConsultar.TabIndex = 74;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtNroCliente
            // 
            this.txtNroCliente.Location = new System.Drawing.Point(171, 71);
            this.txtNroCliente.Name = "txtNroCliente";
            this.txtNroCliente.Size = new System.Drawing.Size(147, 20);
            this.txtNroCliente.TabIndex = 6;
            this.txtNroCliente.Visible = false;
            // 
            // ListadoTelefonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.panelRd);
            this.Controls.Add(this.reportTelefonos);
            this.Controls.Add(this.btnMinimizarPantallaReg);
            this.Controls.Add(this.btnCerrarPantallaReg);
            this.Controls.Add(this.lblListadoTelefonos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoTelefonos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Telefonos";
            this.Load += new System.EventHandler(this.ListadoTelefonos_Load);
            this.panelRd.ResumeLayout(false);
            this.panelRd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListadoTelefonos;
        private FontAwesome.Sharp.IconButton btnMinimizarPantallaReg;
        private FontAwesome.Sharp.IconButton btnCerrarPantallaReg;
        private Microsoft.Reporting.WinForms.ReportViewer reportTelefonos;
        private System.Windows.Forms.Panel panelRd;
        private System.Windows.Forms.RadioButton rdBtnFiltrarNroCliente;
        private System.Windows.Forms.TextBox txtCodArea;
        private System.Windows.Forms.TextBox txtCodPais;
        private System.Windows.Forms.RadioButton rdBtnFiltrarPorCodArea;
        private System.Windows.Forms.RadioButton rdBtnFiltrarPorCodPais;
        private System.Windows.Forms.RadioButton rdBtnTodosTelefonos;
        private RJCodeAdvance.RJControls.RJButton btnConsultar;
        private System.Windows.Forms.TextBox txtNroCliente;
    }
}