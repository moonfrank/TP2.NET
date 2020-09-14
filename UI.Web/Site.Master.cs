using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            switch (Session["Persona"].ToString())
            {
                case "Alumno":
                    //menu..Remove(menu.FindItem(@"Home\Planes"));
                    //MenuItem mnuItem = Menu1.FindItem("@"Home\Planes""); // Find particular item
                    //Menu1.Items.Remove(mnuItem);

                    SiteMapNodeItem homeMenuItem = SiteMapNode.;

                    MenuItem movieSubMenuItem = menu.FindItem(@"Home\Planes");

                    // Remove the Movie submenu item.
                    if (movieSubMenuItem != null)
                    {
                        homeMenuItem.ChildItems.Remove(movieSubMenuItem);
                    }
                    break;
            }
        }
    }
}