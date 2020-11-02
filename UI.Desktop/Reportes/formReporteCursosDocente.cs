using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI.Desktop.Reportes
{
    public partial class formReporteCursosDocente : UI.Desktop.ApplicationForm
    {
        public formReporteCursosDocente()
        {
            this.Controls.Add(this.reportViewer1);
            InitializeComponent();
            
        }
        private void formReporteCursosDocente_Load(object sender, EventArgs e)
        {
            this.reportCursoDocente.RefreshReport();
        }
    }
}
