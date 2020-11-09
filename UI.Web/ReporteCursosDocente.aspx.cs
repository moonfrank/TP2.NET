using System;
using System.Linq;
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
            {
                docente = int.Parse(Session["IDPersona"].ToString());
                fillReporte(docente);
            }  
            else
            {
                if (ddlIDDocente.Items.Count==0)
                    this.fillddlIDDocente();
                this.panelIDDocente.Visible = true;
            }

        }

        protected void fillddlIDDocente()
        {
            var idProfesores = from a in new PersonaLogic().GetAll()
                               where a.TipoPersona.ToString() == "Profesor"
                               select a.ID;

            foreach (int p in idProfesores)
            {
                ddlIDDocente.Items.Add(p.ToString());
            }
        }
        protected void fillReporte(int docente)
        {
            if (docente != -1)
            {
                var query = from a in new CursoLogic().GetAll()
                            join b in new DocenteCursoLogic().GetAll() on a.ID equals b.IDCurso
                            where b.IDDocente == docente
                            select a;

                reportCursoDocente.LocalReport.DataSources.Clear();
                reportCursoDocente.LocalReport.DataSources.Add(new ReportDataSource("ReporteCursos", query));
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            this.fillReporte(int.Parse(this.ddlIDDocente.SelectedValue));
        }
    }
    }
