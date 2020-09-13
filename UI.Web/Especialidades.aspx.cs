using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class Especialidades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) LoadGrid();
        }
        EspecialidadLogic _logic;
        private EspecialidadLogic Logic
        {
            get
            {
                
             if (_logic == null)
            {
                _logic = new EspecialidadLogic();
            }
            return _logic;
            }
        }
        private void LoadGrid()
        {
            this.grdEspecialidades.DataSource = this.Logic.GetAll();
            this.grdEspecialidades.DataBind();
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
        private Especialidad Entity
        {
            get; set;
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
      
        private void LoadForm(int ID)
        {
            Especialidad especialidad = new EspecialidadLogic().GetOne(ID);
            txtDescripcion.Text = especialidad.Descripcion;
        }
        private void EnableForm(bool enable)
        {
            txtDescripcion.Enabled = enable;
        }
        private void ClearForm()
        {
            txtDescripcion.Text = string.Empty;
        }
        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedID = (int)grdEspecialidades.SelectedValue;
        }
        private void LoadEntity(Especialidad especialidad)
        {
            especialidad.Descripcion = txtDescripcion.Text;
        }
        private void SaveEntity(Especialidad especialidad)
        {
            new EspecialidadLogic().Save(especialidad);
        }
        private void DeleteEntity(int ID)
        {
            new EspecialidadLogic().Delete(ID);
        }



        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            formPanel.Visible = false;
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
             this.formPanel.Visible = true;
             this.FormMode = FormModes.Alta;
             this.ClearForm();
             this.EnableForm(true);
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (IsEntitySelected)
            {
                formPanel.Visible = true;
                FormMode = FormModes.Modificacion;
                LoadForm(SelectedID);
                EnableForm(true);
            }
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (IsEntitySelected)
            {
                formPanel.Visible = true;
                FormMode = FormModes.Baja;
                EnableForm(false);
                LoadForm(SelectedID);
            }
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            switch (FormMode)
            {
                case FormModes.Baja:
                    DeleteEntity(SelectedID);
                    LoadGrid();
                    break;
                case FormModes.Modificacion:
                    Entity = new Especialidad();
                    Entity.ID = SelectedID;
                    Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    LoadGrid();
                    break;
                case FormModes.Alta:
                    Entity = new Especialidad();
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
    }
}