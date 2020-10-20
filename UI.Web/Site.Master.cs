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
                    {
                        menuitem.ChildItems.Remove(menu.FindItem(@"Home\Planes"));
                        menuitem.ChildItems.Remove(menu.FindItem(@"Home\Comisiones"));
                        menuitem.ChildItems.Remove(menu.FindItem(@"Home\Docentes Cursos"));
                        menuitem.ChildItems.Remove(menu.FindItem(@"Home\Alumnos Inscripciones"));
                        menuitem.ChildItems.Remove(menu.FindItem(@"Home\Especialidades"));
                        menuitem.ChildItems.Remove(menu.FindItem(@"Home\Materias"));
                        menuitem.ChildItems.Remove(menu.FindItem(@"Home\Usuarios"));
                        menuitem.ChildItems.Remove(menu.FindItem(@"Home\Personas"));
                    }                        
                    else throw new Exception();
                    break;
                case "Profesor":
                    if (menuitem != null)
                    {
                        menuitem.ChildItems.Remove(menu.FindItem(@"Home\Planes"));
                        menuitem.ChildItems.Remove(menu.FindItem(@"Home\Comisiones"));
                        menuitem.ChildItems.Remove(menu.FindItem(@"Home\Especialidades"));
                        menuitem.ChildItems.Remove(menu.FindItem(@"Home\Materias"));
                        menuitem.ChildItems.Remove(menu.FindItem(@"Home\Usuarios"));
                        menuitem.ChildItems.Remove(menu.FindItem(@"Home\Personas"));
                    }
                    else throw new Exception();
                    break;
                case "Admin":
                    if (menuitem != null) { }
                    else throw new Exception();
                    break;
            }
                
        }
    }
}