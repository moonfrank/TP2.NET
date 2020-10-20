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
    public partial class Docentes_Cursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { LoadGrid(); }
        }
        DocenteCursoLogic _logic;
        private DocenteCursoLogic Logic
        {
            get
            {
                if (_logic == null) { _logic = new DocenteCursoLogic(); }
                return _logic;
            }
        }
        private void LoadGrid()
        {
            this.GridView.DataSource = this.Logic.GetAll();
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
        private DocenteCurso Entity
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
        protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.GridView.SelectedValue;
        }
        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.ddlCargo.SelectedValue = this.Entity.Cargo.ToString();
            this.ddlIDCurso.SelectedValue = this.Entity.IDCurso.ToString();
            this.ddlIDDocente.SelectedValue = this.Entity.IDDocente.ToString();
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
        private void LoadEntity(DocenteCurso docenteCurso)
        {
            Enum.TryParse<DocenteCurso.TiposCargos>(this.ddlCargo.SelectedValue.ToString(), out DocenteCurso.TiposCargos tipoCargo);
            docenteCurso.Cargo = tipoCargo; 
            docenteCurso.IDCurso = int.Parse(this.ddlIDCurso.SelectedValue);
            docenteCurso.IDDocente = int.Parse(this.ddlIDDocente.SelectedValue);
        }
        private void SaveEntity(DocenteCurso docenteCurso)
        {
            this.Logic.Save(docenteCurso);  
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
        }
        private void EnableForm(bool enable)
        {
            ddlIDDocente.Enabled = enable;
            ddlIDCurso.Enabled = enable;
            ddlCargo.Enabled = enable;
        }
        private void ListarCBX()
        {
            foreach (Curso curso in new CursoLogic().GetAll())
            {
                ddlIDCurso.Items.Add(curso.ID.ToString());
            }

            var profesor = from a in new PersonaLogic().GetAll()
                         where a.TipoPersona.ToString() == "Profesor"
                         select a;
            foreach (Persona persona in profesor)
            {
                ddlIDDocente.Items.Add(persona.ID.ToString());
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
            this.ddlCargo.SelectedValue = string.Empty;
            this.ddlIDCurso.SelectedValue = string.Empty;
            this.ddlIDDocente.SelectedValue = string.Empty;
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            formPanel.Visible = true;
        }
    }
}