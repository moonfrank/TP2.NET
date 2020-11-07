using Microsoft.Reporting.WinForms;
using System;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop.Reportes
{
    public partial class formReporteCursosDocente : ApplicationForm
    {
        public formReporteCursosDocente()
        {
            InitializeComponent();
        }
        private void formReporteCursosDocente_Load(object sender, EventArgs e)
        {
            int docente = -1;
            if (session.tipoPersona == Persona.TiposPersonas.Profesor)
                docente = session.personaID;
            else
            {
                formIngresoIDDocente ingresoDocente = new formIngresoIDDocente();
                if (ingresoDocente.ShowDialog() != DialogResult.OK) this.Dispose();
                else docente = ingresoDocente.docente;
            }
            if (docente != -1)
            {
                var query = from a in new CursoLogic().GetAll()
                            join b in new DocenteCursoLogic().GetAll() on a.ID equals b.IDCurso
                            where b.IDDocente == docente
                            select a;

                reportCursoDocente.LocalReport.DataSources.Add(new ReportDataSource("ReporteCursos", query));
                reportCursoDocente.RefreshReport();
            }
            else
                this.Dispose();
        }
    }
}
