using System;
using System.Web.UI;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class Materias : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.SessionID != null) Response.Redirect("Login.aspx");
            else if (!IsPostBack) LoadGrid();
        }
        MateriaLogic _logic;
        private MateriaLogic Logic
        {
            get
            {
                if (_logic == null) { _logic = new MateriaLogic(); }
                return _logic;
            }
        }
        private void LoadGrid()
        {
            if (Session["Persona"].ToString() != "Admin")
            {
                this.gridActionsPanel.Visible = false;
            }
            this.grdMaterias.DataSource = this.Logic.GetAll();
            this.grdMaterias.DataBind();
        }
        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion
        }
        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }
        private Materia Entity
        {
            get; set;
        }
        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null) return (int)this.ViewState["SelectedID"];
                else return 0;
            }
            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }
        private bool IsEntitySelected
        {
            get
            {
                return (this.SelectedID != 0);
            }
        }

        protected void grdMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.grdMaterias.SelectedValue;
        }
        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.txtDescripcion.Text = this.Entity.Descripcion;
            this.txtHorasSem.Text = this.Entity.HsSemanales.ToString();
            this.txtHorasTot.Text = this.Entity.HsTotales.ToString();
            this.ddlIDPlan.SelectedValue = this.Entity.IDPlan.ToString();
        }
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.EnableForm(true);
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(SelectedID);
            }
        }
        private void LoadEntity(Materia materia)
        {
            materia.Descripcion = this.txtDescripcion.Text;
            materia.HsSemanales = int.Parse(this.txtHorasSem.Text);
            materia.HsTotales = int.Parse(this.txtHorasTot.Text);
            materia.IDPlan = int.Parse(this.ddlIDPlan.SelectedValue);
        }
        private void SaveEntity(Materia materia)
        {
            this.Logic.Save(materia);
        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    this.Entity = new Materia();
                    this.Entity.State = BusinessEntity.States.New;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid(); break;
                case FormModes.Baja:
                    this.Entity.State = BusinessEntity.States.Deleted;
                    this.DeleteEntity(SelectedID);
                    this.LoadGrid(); break;
                case FormModes.Modificacion:
                    this.Entity = new Materia();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid(); break;
                default:
                    break;
            }
            this.formPanel.Visible = false;
            this.gridActionsPanel.Visible = false;
        }
        private void EnableForm(bool enable)
        {
            txtDescripcion.Enabled = enable;
            txtHorasSem.Enabled = enable;
            txtHorasTot.Enabled = enable;
            ddlIDPlan.Enabled = enable;
            ListarIDPlanes();
        }
        private void ListarIDPlanes()
        {
            foreach (Plan plan in new PlanLogic().GetAll())
            {
                ddlIDPlan.Items.Add(plan.ID.ToString());
            }
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = false;
                this.FormMode = FormModes.Baja;
                this.EnableForm(false);
                this.LoadForm(this.SelectedID);
            }
        }
        private void DeleteEntity(int id)
        {
            this.Logic.Delete(SelectedID);
        }
        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm(); // limpia los controles
            this.EnableForm(true);
        }
        private void ClearForm()
        {
            this.txtDescripcion.Text = string.Empty;
            this.txtHorasSem.Text = string.Empty;
            this.txtHorasTot.Text = string.Empty;
            this.ddlIDPlan.SelectedValue = string.Empty;
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = false;
            this.gridActionsPanel.Visible = false;
        }
    }
}