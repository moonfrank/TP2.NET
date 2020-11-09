using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;

namespace UI.Web
{
    public partial class IngresoIDDocente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var idProfesores = from a in new PersonaLogic().GetAll()
                               where a.TipoPersona.ToString() == "Profesor"
                               select a.ID;

            foreach (int p in idProfesores)
            {
                lbIDDocente.Items.Add(p.ToString());
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            docente = int.Parse(lbIDDocente.Text);
        }
        public int docente;


    }
}