using System;
using System.Web.UI;
using Business.Logic;
using Business.Entities;

namespace UI.Web
{
    public partial class Planes : System.Web.UI.Page
    {
        PlanLogic _logic;
        private PlanLogic Logic
        {
            get
            { if (_logic == null) { _logic = new PlanLogic(); } return _logic; }
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
        private Plan Entity { get; set; }
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) LoadGrid();
        }
        private void LoadGrid()
        {
            gridView.DataSource = this.Logic.GetAll();
            gridView.DataBind();
        }

        private void LoadForm(int id)
        {
            Entity = this.Logic.GetOne(id);
            txtDescripcion.Text = this.Entity.Descripcion;
            ddlIDEspecialidad.Text = this.Entity.IDEspecialidad.ToString();
        }
        private void EnableForm(bool enable)
        {
            txtDescripcion.Enabled = enable;
            ddlIDEspecialidad.Enabled = enable;
            ListarEspecialidades();
        }
        private void ClearForm()
        {
            this.txtDescripcion.Text = string.Empty;
            this.ddlIDEspecialidad.Text = string.Empty;
        }
        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedID = (int)gridView.SelectedValue;
        }
        private void LoadEntity(Plan plan)
        {
            plan.Descripcion = this.txtDescripcion.Text;
            plan.IDEspecialidad = int.Parse(this.ddlIDEspecialidad.Text);
        }
        private void SaveEntity(Plan plan)
        {
            this.Logic.Save(plan);
        }
        private void DeleteEntity(int ID)
        {
            this.Logic.Delete(ID);
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
                    Entity = new Plan();
                    Entity.ID = SelectedID;
                    Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    LoadGrid();
                    break;
                case FormModes.Alta:
                    Entity = new Plan();
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
            formPanel.Visible = true;
        }

        private void ListarEspecialidades()
        {
            foreach (Especialidad espe in new EspecialidadLogic().GetAll())
            {
                ddlIDEspecialidad.Items.Add(espe.ID.ToString());
            }
        }


    }
}