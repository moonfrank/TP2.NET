using Business.Logic;
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
    public partial class Usuarios : System.Web.UI.Page
    {
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
            Listar();
        }
        private void Listar()
        {
            gridView.DataSource = new UsuarioLogic().GetAll();
            gridView.DataBind();
        }

        private void LoadForm (int ID)
        {
            Entity = new UsuarioLogic().GetOne(ID);
            txtNombre.Text = Entity.Nombre;
            txtApellido.Text = Entity.Apellido;
            txtEmail.Text = Entity.Email;
            txtNombreUsuario.Text = Entity.NombreUsuario;
            txtClave.Text = Entity.Clave;
            ckbHabilitado.Checked = Entity.Habilitado;
        }

        protected void gridView_SelectedIndexChanged1(object sender, EventArgs e)
        {
            SelectedID = (int)gridView.SelectedValue;
        }

        protected void btnEditar_Click1(object sender, EventArgs e)
        {
            if (IsEntitySelected)
            {
                formPanel.Visible = true;
                FormMode = FormModes.Modificacion;
                LoadForm(SelectedID);
                EnableForm(true);
            }
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
        
        private void DeleteEntity(int ID)
        {
            new UsuarioLogic().Delete(ID);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (FormMode)
            {
                case FormModes.Baja:
                    DeleteEntity(SelectedID);
                    Listar();
                    break;
                case FormModes.Modificacion:
                    Entity = new Usuario();
                    Entity.ID = SelectedID;
                    Entity.State = BusinessEntity.States.Modified;
                    Listar();
                    break;
                default:
                    break;
            }
            formPanel.Visible = false;
        }
    }
}