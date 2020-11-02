namespace UI.Desktop.Reportes
{
    partial class formReporteCursosDocente
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
            this.reportCursoDocente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportCursoDocente
            // 
            this.reportCursoDocente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportCursoDocente.LocalReport.ReportEmbeddedResource = "UI.Desktop.Reportes.ReportCursosDocente.rdlc";
            this.reportCursoDocente.Location = new System.Drawing.Point(0, 0);
            this.reportCursoDocente.Name = "reportCursoDocente";
            this.reportCursoDocente.ServerReport.BearerToken = null;
            this.reportCursoDocente.Size = new System.Drawing.Size(631, 436);
            this.reportCursoDocente.TabIndex = 0;
            // 
            // formReporteCursosDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(631, 436);
            this.Controls.Add(this.reportCursoDocente);
            this.Name = "formReporteCursosDocente";
            this.Text = "Cursos por Docente";
            this.Load += new System.EventHandler(this.formReporteCursosDocente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportCursoDocente;
    }
}
