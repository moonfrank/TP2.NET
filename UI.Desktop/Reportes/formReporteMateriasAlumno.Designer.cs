namespace UI.Desktop.Reportes
{
    partial class formReporteMateriasAlumno
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
            this.reportMateriasAlumno = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportMateriasAlumno
            // 
            this.reportMateriasAlumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportMateriasAlumno.LocalReport.ReportEmbeddedResource = "UI.Desktop.Reportes.ReportMateriasAlumno.rdlc";
            this.reportMateriasAlumno.Location = new System.Drawing.Point(0, 0);
            this.reportMateriasAlumno.Name = "reportMateriasAlumno";
            this.reportMateriasAlumno.ServerReport.BearerToken = null;
            this.reportMateriasAlumno.Size = new System.Drawing.Size(800, 450);
            this.reportMateriasAlumno.TabIndex = 0;
            // 
            // formReporteMateriasAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportMateriasAlumno);
            this.Name = "formReporteMateriasAlumno";
            this.Text = "Materias Alumno";
            this.Load += new System.EventHandler(this.formReporteMateriasAlumno_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportMateriasAlumno;
    }
}
