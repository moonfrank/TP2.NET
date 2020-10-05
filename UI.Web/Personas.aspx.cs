using System;
using System.Web.UI;
using Business.Logic;
using Business.Entities;

namespace UI.Web
{
    public partial class Personas : System.Web.UI.Page
    {

        private Persona Entity { get; set; }
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
            gridViewPersona.DataSource = new PersonaLogic().GetAll();
            gridViewPersona.DataBind();
            ddlTipoPersona.DataSource = Enum.GetNames(typeof(Persona.TiposPersonas));
            ddlTipoPersona.DataBind();
        }
        private void LoadForm(int ID)
        {
            Persona persona = new PersonaLogic().GetOne(ID);
            ddlTipoPersona.Text = persona.TipoPersona.ToString();
            txtLegajo.Text = persona.Legajo.ToString();
            txtNombre.Text = persona.Nombre;
            txtApellido.Text = persona.Apellido;
            txtDireccion.Text = persona.Direccion;
            txtTelefono.Text = persona.Telefono;
            txtFechaNacimiento.Text = persona.FechaNacimiento.ToString("dd/MM/yyyy");
            ddlIDPlan.Text = persona.IDPlan.ToString();
        }
        private void EnableForm(bool enable)
        {
            txtLegajo.Enabled = enable;
            txtNombre.Enabled = enable;
            txtApellido.Enabled = enable;
            txtDireccion.Enabled = enable;
            txtTelefono.Enabled = enable;
            txtFechaNacimiento.Enabled = enable;
            ddlIDPlan.Enabled = enable;
            ddlTipoPersona.Enabled = enable;
            foreach (Plan plan in new PlanLogic().GetAll())
            {
                ddlIDPlan.Items.Add(plan.ID.ToString());
            }
        }
        private void ClearForm()
        {
            txtLegajo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtFechaNacimiento.Text = string.Empty;
        }
        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedID = (int)gridViewPersona.SelectedValue;
        }
        private void LoadEntity(Persona persona)
        {
            persona.Legajo = Convert.ToInt32(txtLegajo.Text);
            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.Direccion = txtDireccion.Text;
            persona.Telefono = txtTelefono.Text;
            persona.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            persona.IDPlan = Convert.ToInt32(ddlIDPlan.SelectedValue);
            persona.TipoPersona = (Persona.TiposPersonas)Enum.Parse(typeof(Persona.TiposPersonas), ddlTipoPersona.SelectedValue);
        }
        private void SaveEntity(Persona persona)
        {
            new PersonaLogic().Save(persona);
        }
        private void DeleteEntity(int ID)
        {
            new PersonaLogic().Delete(ID);
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
                    Entity = new Persona();
                    Entity.ID = SelectedID;
                    Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    LoadGrid();
                    break;
                case FormModes.Alta:
                    Entity = new Persona();
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