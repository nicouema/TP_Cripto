namespace Criptomonedas.Formularios_Ventanas_.Listados
{
    partial class ListadoTransaccionRestriccion
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
            this.btnBuscar = new RJCodeAdvance.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbXCliente = new System.Windows.Forms.RadioButton();
            this.rbXDoc = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.lblListadoTransaccion = new System.Windows.Forms.Label();
            this.reportTpM = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnMinimizarPantallaReg = new FontAwesome.Sharp.IconButton();
            this.btnCerrarPantallaReg = new FontAwesome.Sharp.IconButton();
            this.mbDoc = new System.Windows.Forms.MaskedTextBox();
            this.mbCliente = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnBuscar.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.btnBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscar.BorderRadius = 0;
            this.btnBuscar.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(637, 157);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 27);
            this.btnBuscar.TabIndex = 39;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mbCliente);
            this.panel1.Controls.Add(this.mbDoc);
            this.panel1.Controls.Add(this.rbXCliente);
            this.panel1.Controls.Add(this.rbXDoc);
            this.panel1.Controls.Add(this.rbTodos);
            this.panel1.Location = new System.Drawing.Point(13, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 133);
            this.panel1.TabIndex = 38;
            // 
            // rbXCliente
            // 
            this.rbXCliente.AutoSize = true;
            this.rbXCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbXCliente.Location = new System.Drawing.Point(16, 95);
            this.rbXCliente.Name = "rbXCliente";
            this.rbXCliente.Size = new System.Drawing.Size(132, 20);
            this.rbXCliente.TabIndex = 2;
            this.rbXCliente.TabStop = true;
            this.rbXCliente.Text = "Buscar por cliente";
            this.rbXCliente.UseVisualStyleBackColor = true;
            this.rbXCliente.CheckedChanged += new System.EventHandler(this.rbXCliente_CheckedChanged);
            // 
            // rbXDoc
            // 
            this.rbXDoc.AutoSize = true;
            this.rbXDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbXDoc.Location = new System.Drawing.Point(16, 54);
            this.rbXDoc.Name = "rbXDoc";
            this.rbXDoc.Size = new System.Drawing.Size(162, 20);
            this.rbXDoc.TabIndex = 1;
            this.rbXDoc.TabStop = true;
            this.rbXDoc.Text = "Buscar por Documento";
            this.rbXDoc.UseVisualStyleBackColor = true;
            this.rbXDoc.CheckedChanged += new System.EventHandler(this.rbXDoc_CheckedChanged);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.Location = new System.Drawing.Point(16, 14);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(65, 20);
            this.rbTodos.TabIndex = 0;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // lblListadoTransaccion
            // 
            this.lblListadoTransaccion.AutoSize = true;
            this.lblListadoTransaccion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblListadoTransaccion.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoTransaccion.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblListadoTransaccion.Location = new System.Drawing.Point(12, 11);
            this.lblListadoTransaccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListadoTransaccion.Name = "lblListadoTransaccion";
            this.lblListadoTransaccion.Size = new System.Drawing.Size(638, 36);
            this.lblListadoTransaccion.TabIndex = 37;
            this.lblListadoTransaccion.Text = "Listado de Transacciones con Restriccion";
            // 
            // reportTpM
            // 
            this.reportTpM.LocalReport.ReportEmbeddedResource = "Criptomonedas.ListadoTransacciones.rdlc";
            this.reportTpM.Location = new System.Drawing.Point(13, 189);
            this.reportTpM.Name = "reportTpM";
            this.reportTpM.ServerReport.BearerToken = null;
            this.reportTpM.Size = new System.Drawing.Size(715, 395);
            this.reportTpM.TabIndex = 36;
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
            this.btnMinimizarPantallaReg.Location = new System.Drawing.Point(672, 0);
            this.btnMinimizarPantallaReg.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizarPantallaReg.Name = "btnMinimizarPantallaReg";
            this.btnMinimizarPantallaReg.Size = new System.Drawing.Size(34, 20);
            this.btnMinimizarPantallaReg.TabIndex = 41;
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
            this.btnCerrarPantallaReg.Location = new System.Drawing.Point(706, 0);
            this.btnCerrarPantallaReg.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarPantallaReg.Name = "btnCerrarPantallaReg";
            this.btnCerrarPantallaReg.Size = new System.Drawing.Size(34, 20);
            this.btnCerrarPantallaReg.TabIndex = 40;
            this.btnCerrarPantallaReg.UseVisualStyleBackColor = false;
            this.btnCerrarPantallaReg.Click += new System.EventHandler(this.btnCerrarPantallaReg_Click);
            // 
            // mbDoc
            // 
            this.mbDoc.Location = new System.Drawing.Point(184, 54);
            this.mbDoc.Mask = "99999999";
            this.mbDoc.Name = "mbDoc";
            this.mbDoc.Size = new System.Drawing.Size(55, 20);
            this.mbDoc.TabIndex = 3;
            // 
            // mbCliente
            // 
            this.mbCliente.Location = new System.Drawing.Point(184, 95);
            this.mbCliente.Mask = "99999999";
            this.mbCliente.Name = "mbCliente";
            this.mbCliente.Size = new System.Drawing.Size(55, 20);
            this.mbCliente.TabIndex = 4;
            // 
            // ListadoTransaccionRestriccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 594);
            this.Controls.Add(this.btnMinimizarPantallaReg);
            this.Controls.Add(this.btnCerrarPantallaReg);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblListadoTransaccion);
            this.Controls.Add(this.reportTpM);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoTransaccionRestriccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoTransaccionRestriccion";
            this.Load += new System.EventHandler(this.ListadoTransaccionRestriccion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJButton btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbXCliente;
        private System.Windows.Forms.RadioButton rbXDoc;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.Label lblListadoTransaccion;
        private Microsoft.Reporting.WinForms.ReportViewer reportTpM;
        private FontAwesome.Sharp.IconButton btnMinimizarPantallaReg;
        private FontAwesome.Sharp.IconButton btnCerrarPantallaReg;
        private System.Windows.Forms.MaskedTextBox mbCliente;
        private System.Windows.Forms.MaskedTextBox mbDoc;
    }
}