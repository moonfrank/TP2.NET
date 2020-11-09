using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;
using Microsoft.Reporting.WebForms;

namespace UI.Web
{
    public partial class ReporteCursosDocente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void reportCursosDocente_Load(object sender, EventArgs e)
        {
            int docente = -1;
            if (Session["Persona"].ToString() == "Profesor")
                docente = int.Parse((string)Session["IDPersona"]);
            else
            {
                IngresoIDDocente ingresoDocente = new IngresoIDDocente();
                docente = ingresoDocente.docente;
            }
            if (docente != -1)
            {
                var query = from a in new CursoLogic().GetAll()
                            join b in new DocenteCursoLogic().GetAll() on a.ID equals b.IDCurso
                            where b.IDDocente == docente
                            select a;

                reportCursoDocente.LocalReport.DataSources.Add(new ReportDataSource("ReporteCursos", query));
            }
            else
                this.Dispose();
            }
        }
    }