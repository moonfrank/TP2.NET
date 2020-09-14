using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            Usuario usr = new UsuarioLogic().GetOne(txtUsuario.Text, txtClave.Text);
            if (usr.Nombre != null)
            {
                args.IsValid = true;
                ManejoSession(usr);
                Response.Redirect("Home.aspx");
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void ManejoSession(Usuario usu)
        {
            switch (usu.IDPersona)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}