using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;

namespace UI.Web
{
    public partial class Comisiones : System.Web.UI.Page
    {
        private Comision Entity { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) LoadGrid();
        }
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
        private int SelectedID
        {
            get
            {
                if (ViewState["SelectedID"] != null)
                {
                    return (int)ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                ViewState["SelectedID"] = value;
            }
        }
        private bool IsEntitySelected
        {
            get
            {
                return (SelectedID != 0);
            }
        }
        private void LoadGrid()
        {
            gridViewComision.DataSource = new ComisionLogic().GetAll();
            gridViewComision.DataBind();
        }
        private void LoadForm(int ID)
        {
            Comision Comision = new ComisionLogic().GetOne(ID);
            txtDescripcion.Text = Comision.Descripcion;
            txtAño.Text = Comision.AnioEspecialidad.ToString();
            ddlID.Text = Comision.IDPlan.ToString();                      
        }
        private void EnableForm(bool enable)
        {
            txtAño.Enabled = enable;
            txtDescripcion.Enabled = enable;
            ddlID.Enabled = enable;
            foreach (Plan plan in new PlanLogic().GetAll())
            {
                ddlID.Items.Add(plan.ID.ToString());
            }
        }
        private void ClearForm()
        {
            txtDescripcion.Text = string.Empty;
            txtAño.Text = string.Empty;
            ddlID.DataSource = string.Empty;
        }
        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedID = (int)gridViewComision.SelectedValue;
        }
        private void LoadEntity(Comision comision)
        {
            comision.Descripcion = txtDescripcion.Text;
            comision.AnioEspecialidad = int.Parse(txtAño.Text);
            comision.IDPlan = Convert.ToInt32(ddlID.SelectedValue);
        }
        private void SaveEntity(Comision comision)
        {
            new ComisionLogic().Save(comision);
        }
        private void DeleteEntity(int ID)
        {
            new ComisionLogic().Delete(ID);
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            if (IsEntitySelected)
            {
                formPanel.Visible = true;
                FormMode = FormModes.Modificacion;
                LoadForm(SelectedID);
                EnableForm(true);
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IsEntitySelected)
            {
                formPanel.Visible = true;
                FormMode = FormModes.Baja;
                EnableForm(false);
                LoadForm(SelectedID);
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (FormMode)
            {
                case FormModes.Baja:
                    DeleteEntity(SelectedID);
                    LoadGrid();
                    break;
                case FormModes.Modificacion:
                    Entity = new Comision();
                    Entity.ID = SelectedID;
                    Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    LoadGrid();
                    break;
                case FormModes.Alta:
                    Entity = new Comision();
                    Entity.State = BusinessEntity.States.New;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    LoadGrid();
                    break;
                default:
                    break;
            }
            formPanel.Visible = false;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            formPanel.Visible = false;
        }
    }
}