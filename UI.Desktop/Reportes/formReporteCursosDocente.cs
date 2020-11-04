using Microsoft.Reporting.WinForms;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            // reportCursoDocente.LocalReport.ReportPath = @"";
            // reportCursoDocente.ProcessingMode = ProcessingMode.Local;
            int docente;
            if (session.tipoPersona == Persona.TiposPersonas.Profesor)
                docente = session.personaID;
            else
                docente = 0;

            var query = from a in new CursoLogic().GetAll()
                        join b in new DocenteCursoLogic().GetAll() on a.ID equals b.IDCurso
                        where b.IDDocente == docente
                        select a;

            reportCursoDocente.LocalReport.DataSources.Add(new ReportDataSource("Cursos por Docente", query));
            reportCursoDocente.RefreshReport();
        }
    }
}
