using System;

namespace UI.Web
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region probando de hacer cosas con roles (parcialmente implementado, falta bastante)
            /*
            string[] rol = {Session["Persona"].ToString()};
            HttpContext.Current.User = new GenericPrincipal(HttpContext.Current.User.Identity, rol);
            */
            #endregion

            menu.DataSource = SiteMapDataSource;
            menu.DataBind();
            
            var menuitem = menu.FindItem(@"Home");

            switch (Session["Persona"].ToString())
            {
                case "Alumno":
                    if (menuitem != null)
                        menuitem.ChildItems.Remove(menu.FindItem(@"Home\Planes"));
                    else throw new Exception();
                    break;
                default:
                    break;
            }
                
        }
    }
}