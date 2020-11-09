using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class IngresoLegajoAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public int alumno;

        protected void btnOK_Click1(object sender, EventArgs e)
        {
            while (!int.TryParse(txtLegajo.Text, out alumno)) txtLegajo.Text = "Error en el formato del legajo";
            alumno = int.Parse(txtLegajo.Text);
        }
    }
}