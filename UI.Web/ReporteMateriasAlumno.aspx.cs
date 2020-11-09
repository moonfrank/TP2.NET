using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;
using Microsoft.Reporting.WebForms;
using Microsoft.Reporting.Map;

namespace UI.Web
{
    public partial class ReporteMateriasAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void reportMateriasAlumno_Load(object sender, EventArgs e)
        {
            int alumno = -1;
            if (Session["Persona"].ToString() == "Alumno")
                alumno = (from a in new PersonaLogic().GetAll()
                          where a.ID == int.Parse(Session["IDPersona"].ToString())
                          select a)
                          .First().Legajo;
            else
            {
                IngresoLegajoAlumno ingresoAlumno = new IngresoLegajoAlumno();
                alumno = ingresoAlumno.alumno;
            }

            if (alumno != -1)
            {
                var query = from a in new AlumnoInscripcionLogic().GetAll()
                            join b in new PersonaLogic().GetAll() on a.IDAlumno equals b.ID
                            join c in new CursoLogic().GetAll() on a.IDCurso equals c.ID
                            join d in new MateriaLogic().GetAll() on c.IDMateria equals d.ID
                            where b.Legajo == alumno && a.Condicion == "Aprobado"
                            select new
                            {
                                Materia = d.Descripcion,
                                a.Nota,
                                Anio = c.AnioCalendario
                            };

                reportMateriasAlumno.LocalReport.DataSources.Clear();
                reportMateriasAlumno.LocalReport.DataSources.Add(new ReportDataSource("dsInscripcion", query));
            }
            else
                this.Dispose();
        }
    }
}