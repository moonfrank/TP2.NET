namespace UI.Desktop.Reportes
{
    partial class formIngresoIDDocente
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
            this.lblIDDocente = new System.Windows.Forms.Label();
            this.cboxIDDocente = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIDDocente
            // 
            this.lblIDDocente.AutoSize = true;
            this.lblIDDocente.Location = new System.Drawing.Point(46, 26);
            this.lblIDDocente.Name = "lblIDDocente";
            this.lblIDDocente.Size = new System.Drawing.Size(60, 13);
            this.lblIDDocente.TabIndex = 0;
            this.lblIDDocente.Text = "ID Profesor";
            // 
            // cboxIDDocente
            // 
            this.cboxIDDocente.FormattingEnabled = true;
            this.cboxIDDocente.Location = new System.Drawing.Point(112, 23);
            this.cboxIDDocente.Name = "cboxIDDocente";
            this.cboxIDDocente.Size = new System.Drawing.Size(68, 21);
            this.cboxIDDocente.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(77, 72);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // formIngresoIDDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(233, 107);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cboxIDDocente);
            this.Controls.Add(this.lblIDDocente);
            this.Name = "formIngresoIDDocente";
            this.Text = "Ingresar ID Docente";
            this.Load += new System.EventHandler(this.formIngresoIDDocente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDDocente;
        private System.Windows.Forms.ComboBox cboxIDDocente;
        private System.Windows.Forms.Button btnOK;
    }
}
