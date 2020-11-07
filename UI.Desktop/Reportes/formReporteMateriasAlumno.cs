using Business.Entities;
using Business.Logic;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace UI.Desktop.Reportes
{
    public partial class formReporteMateriasAlumno : ApplicationForm
    {
        public formReporteMateriasAlumno()
        {
            InitializeComponent();
        }

        private void formReporteMateriasAlumno_Load(object sender, EventArgs e)
        {
            int alumno = -1;
            if (session.tipoPersona == Persona.TiposPersonas.Alumno)
                alumno = (from a in new PersonaLogic().GetAll()
                          where a.ID == session.personaID
                          select a)
                          .First().Legajo;
            else
            {
                formIngresoLegajoAlumno ingresoAlumno = new formIngresoLegajoAlumno();
                if (ingresoAlumno.ShowDialog() != DialogResult.OK) this.Dispose();
                else alumno = ingresoAlumno.alumno;
            }
            if (alumno != -1)
            {
                var query = from a in new AlumnoInscripcionLogic().GetAll()
                            join b in new PersonaLogic().GetAll() on a.IDAlumno equals b.ID
                            join c in new CursoLogic().GetAll() on a.IDCurso equals c.ID
                            where b.Legajo == alumno && a.Condicion == "Aprobado"
                            select a;

                reportMateriasAlumno.LocalReport.DataSources.Add(new ReportDataSource("dsInscripcion", query));
                reportMateriasAlumno.RefreshReport();
            }
            else
                this.Dispose();
        }
    }
}
