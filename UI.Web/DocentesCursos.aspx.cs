using System;
using System.Linq;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class DocentesCursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.SessionID != null)
            {
                if (Session["Persona"].ToString() != "Alumno" && !Page.IsPostBack)
                    LoadGrid();
                else Response.Redirect("Home.aspx");
            }
            else Response.Redirect("Login.aspx");
        }
        DocenteCursoLogic _logic;
        private DocenteCursoLogic Logic
        {
            get
            {
                if (_logic == null) _logic = new DocenteCursoLogic();
                return _logic;
            }
        }
        private void LoadGrid()
        {
            if (Session["Persona"].ToString() == "Profesor")
            {
                this.GridView.DataSource = this.Logic.GetAllByDocente(int.Parse(Session["IDPersona"].ToString()));
                this.gridActionsPanel.Visible = false;
            }
            else this.GridView.DataSource = this.Logic.GetAll();
            this.GridView.DataBind();
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
        private DocenteCurso Entity { get; set; }
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
        protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.GridView.SelectedValue;
        }
        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.ListarDocentes();
            this.ddlCargo.SelectedValue = this.Entity.Cargo.ToString();
            this.ddlIDCurso.SelectedValue = this.Entity.IDCurso.ToString();
            this.ddlIDDocente.SelectedValue = this.Entity.IDDocente.ToString();

        }
        private void ListarDocentes()
        {
            foreach (Curso curso in new CursoLogic().GetAll())
            {
                ddlIDCurso.Items.Add(curso.ID.ToString());
            }

            var profesores = from a in new PersonaLogic().GetAll()
                           where (int)a.TipoPersona == 1
                           select a;
            foreach (Persona persona in profesores)
            {
                ddlIDDocente.Items.Add(persona.ID.ToString());
            }
        }
        private void LoadEntity(DocenteCurso docenteCurso)
        {
            Enum.TryParse(this.ddlCargo.SelectedValue.ToString(), out DocenteCurso.TiposCargos tipoCargo);
            docenteCurso.Cargo = tipoCargo; 
            docenteCurso.IDCurso = int.Parse(this.ddlIDCurso.SelectedValue);
            docenteCurso.IDDocente = int.Parse(this.ddlIDDocente.SelectedValue);
        }
        private void SaveEntity(DocenteCurso docenteCurso)
        {
            this.Logic.Save(docenteCurso);  
        }
        private void DeleteEntity(int id)
        {
            this.Logic.Delete(SelectedID);
        }
        private void EnableForm(bool enable)
        {
            ddlIDDocente.Enabled = enable;
            ddlIDCurso.Enabled = enable;
            ddlCargo.Enabled = enable;
            this.formPanel.Visible = enable;
            this.formActionsPanel.Visible = enable;
        }
        private void ClearForm()
        {
            this.ddlCargo.SelectedValue = string.Empty;
            this.ddlIDCurso.SelectedValue = string.Empty;
            this.ddlIDDocente.SelectedValue = string.Empty;
        }
        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;

            this.ClearForm(); // limpia los controles
            this.ListarDocentes();
            this.EnableForm(true);
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
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    this.Entity = new DocenteCurso();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid(); break;
                case FormModes.Baja:
                    this.DeleteEntity(SelectedID);
                    this.LoadGrid(); break;
                case FormModes.Modificacion:
                    this.Entity = new DocenteCurso();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid(); break;
                default:
                    break;
            }
            this.formPanel.Visible = false;
            this.formActionsPanel.Visible = false;
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            formPanel.Visible = false;
            formActionsPanel.Visible = false;
        }
    }
}