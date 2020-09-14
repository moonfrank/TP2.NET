using System;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;

namespace UI.Web
{
    public partial class Usuarios : System.Web.UI.Page
    {
        UsuarioLogic _logic;
        private UsuarioLogic Logic
        {
            get
            { if (_logic == null) { _logic = new UsuarioLogic(); } return _logic; }
        }
        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion
        }
        public FormModes FormMode
        {
            get { return (FormModes)ViewState["FormMode"];}
            set { ViewState["FormMode"] = value; }
        }
        private Usuario Entity { get; set; }
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
            gridView.DataSource = new UsuarioLogic().GetAll();
            gridView.DataBind();
        }

        private void LoadForm (int ID)
        {
            Entity = this.Logic.GetOne(ID);
            txtNombre.Text = Entity.Nombre;
            txtApellido.Text = Entity.Apellido;
            txtEmail.Text = Entity.Email;
            txtNombreUsuario.Text = Entity.NombreUsuario;
            ckbHabilitado.Checked = Entity.Habilitado;
            ddlIDPersona.Text = Entity.IDPersona.ToString();
        }
        private void EnableForm(bool enable)
        {
            txtNombre.Enabled = enable;
            txtApellido.Enabled = enable;
            txtEmail.Enabled = enable;
            txtNombreUsuario.Enabled = enable;
            txtClave.Enabled = enable;
            lblClave.Visible = enable;
            txtRepetirClave.Enabled = enable;
            lblRepertirClave.Visible = enable;
            ddlIDPersona.Enabled = enable;
            ListarCBX();
        }
        private void ClearForm()
        {
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.ckbHabilitado.Checked = false;
            this.txtNombreUsuario.Text = string.Empty;
            ddlIDPersona.DataSource = string.Empty;
        }
        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedID = (int)gridView.SelectedValue;
        }
        private void LoadEntity(Usuario usuario)
        {
            usuario.Nombre = this.txtNombre.Text;
            usuario.Apellido = this.txtApellido.Text;
            usuario.Email = this.txtEmail.Text;
            usuario.NombreUsuario = this.txtNombreUsuario.Text;
            usuario.Clave = this.txtClave.Text;
            usuario.Habilitado = this.ckbHabilitado.Checked;
            usuario.IDPersona = Convert.ToInt32(ddlIDPersona.SelectedValue);
        }
        private void SaveEntity(Usuario usuario)
        {
            this.Logic.Save(usuario);
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
                    Entity = new Usuario();
                    Entity.ID = SelectedID;
                    Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    LoadGrid();
                    break;
                case FormModes.Alta:
                    Entity = new Usuario();
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

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (Validation.IsEmailValid(txtEmail.Text)) args.IsValid = true;
            else args.IsValid = false;
        }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (txtClave.Text == txtRepetirClave.Text) args.IsValid = true;
            else args.IsValid = false;
        }

        //protected void ddlIDPersona_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Persona persona = new PersonaLogic().GetOne(Convert.ToInt32(ddlIDPersona.SelectedItem));
        //    txtNombre.Text = persona.Nombre;
        //    txtApellido.Text = persona.Apellido;
        //}
        private void ListarCBX()
        {
            foreach (Persona persona in new PersonaLogic().GetAll())
            {
                ddlIDPersona.Items.Add(persona.ID.ToString());
            }
        }
    }
}