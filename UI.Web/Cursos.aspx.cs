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
    public partial class Cursos : System.Web.UI.Page
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
        private Curso Entity { get; set; }
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
            gridViewCurso.DataSource = new CursoLogic().GetAll();
            gridViewCurso.DataBind();
        }

        private void LoadForm(int ID)
        {
            Curso Curso = new CursoLogic().GetOne(ID);
            ddlMateria.Text = Curso.IDMateria.ToString();
            ddlComision.Text = Curso.IDComision.ToString();
            txtAño.Text = Curso.AnioCalendario.ToString();
            txtCupo.Text = Curso.Cupo.ToString();
        }
        private void EnableForm(bool enable)
        {
            ddlMateria.Enabled = enable;
            ddlComision.Enabled = enable;
            txtAño.Enabled = enable;
            txtCupo.Enabled = enable;
            ListarCBX();
        }
        private void ListarCBX()
        {
            foreach (Materia materia in new MateriaLogic().GetAll())
            {
                ddlMateria.Items.Add(materia.ID.ToString());
            }
            foreach (Comision comision in new ComisionLogic().GetAll())
            {
                ddlComision.Items.Add(comision.ID.ToString());
            }
        }
        private void ClearForm()
        {
            ddlComision.DataSource = string.Empty;
            ddlMateria.DataSource = string.Empty;
            this.txtCupo.Text = string.Empty;
            this.txtAño.Text = string.Empty;
        }
        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedID = (int)gridViewCurso.SelectedValue;
        }
        private void LoadEntity(Curso curso)
        {
            curso.IDMateria = Convert.ToInt32(ddlMateria.SelectedValue);
            curso.IDComision = Convert.ToInt32(ddlComision.SelectedValue);
            curso.AnioCalendario = int.Parse(txtAño.Text);
            curso.Cupo = int.Parse(txtCupo.Text);
        }
        private void SaveEntity(Curso curso)
        {
            new CursoLogic().Save(curso);
        }
        private void DeleteEntity(int ID)
        {
            new CursoLogic().Delete(ID);
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
                    Entity = new Curso();
                    Entity.ID = SelectedID;
                    Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    LoadGrid();
                    break;
                case FormModes.Alta:
                    Entity = new Curso();
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