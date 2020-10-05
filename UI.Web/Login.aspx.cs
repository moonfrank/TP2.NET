using Business.Entities;
using Business.Logic;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Business.Entities.Persona;

namespace UI.Web
{
    public partial class Login : Page
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
            switch (new PersonaLogic().GetOne(usu.IDPersona).TipoPersona)
            {
                case TiposPersonas.Alumno: 
                    Session["Persona"] = "Alumno";
                    break;
                case TiposPersonas.Profesor:
                    Session["Persona"] = "Profesor";
                    break;
                case TiposPersonas.Admin:
                    Session["Persona"] = "Admin";
                    break;
            }
            
        }
    }
}