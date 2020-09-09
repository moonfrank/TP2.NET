using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;

namespace UI.Web
{
    public partial class Planes : System.Web.UI.Page
    {
        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion
        }
        public FormModes FormMode
        {
            get { return (FormModes)ViewState["FormMode"]; }
            set { ViewState["FormMode"] = value; }
        }
        private Plan Entity { get; set; }
        private int SelectedID
        {
            get
            {
                if (ViewState["SelectedID"] != null) return (int)ViewState["SelectedID"];
                else return 0;
            }
            set { ViewState["SelectedID"] = value; }
        }
        private bool IsEntitySelected
        {
            get { return (SelectedID != 0); }
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }
        PlanLogic _logic;
        private PlanLogic Logic 
        { get
            { if (_logic == null) { _logic = new PlanLogic(); } return _logic; } }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) LoadGrid();
        }

        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.listIDEspecialidad.Text = this.Entity.IDEspecialidad.ToString();
            this.txtDescripcion.Text = this.Entity.Descripcion;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }
        protected void btnNuevo_Click(object sender, EventArgs e)
        {

        }


    }
}