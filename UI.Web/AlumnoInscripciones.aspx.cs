using System;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;
using System.Linq;

namespace UI.Web
{
    public partial class Alumno_Inscripciones : System.Web.UI.Page
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
        private AlumnoInscripcion Entity { get; set; }
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
            gridView.DataSource = new AlumnoInscripcionLogic().GetAll();
            gridView.DataBind();
        }

        private void LoadForm(int ID)
        {
            Entity = new AlumnoInscripcionLogic().GetOne(ID);
            ddlIDAlumno.Text = Entity.IDAlumno.ToString();
            ddlIDCurso.Text = Entity.IDCurso.ToString();
            txtCondicion.Text = Entity.Condicion;
            txtNota.Text = Entity.Nota.ToString();
        }
        private void EnableForm(bool enable)
        {
            ddlIDAlumno.Enabled = enable;
            ddlIDCurso.Enabled = enable;
            txtCondicion.Enabled = enable;
            txtNota.Enabled = enable;
            ListarCBX();
        }
        private void ListarCBX()
        {
            foreach (Curso curso in new CursoLogic().GetAll())
            {
                ddlIDCurso.Items.Add(curso.ID.ToString());
            }

            var alumno = from a in new PersonaLogic().GetAll()
                         where a.TipoPersona.ToString() == "Alumno"
                         select a;
            foreach (Persona persona in alumno)
            {
                ddlIDAlumno.Items.Add(persona.ID.ToString());
            }
        }
        private void ClearForm()
        {
            ddlIDAlumno.DataSource = string.Empty;
            ddlIDCurso.DataSource = string.Empty;
            this.txtCondicion.Text = string.Empty;
            this.txtNota.Text = string.Empty;
        }
        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedID = (int)gridView.SelectedValue;
        }
        private void LoadEntity(AlumnoInscripcion alumno)
        {
            alumno.IDCurso = Convert.ToInt32(ddlIDCurso.SelectedValue);
            alumno.IDAlumno = Convert.ToInt32(ddlIDAlumno.SelectedValue);
            alumno.Condicion = this.txtCondicion.Text;
            alumno.Nota = int.Parse(txtNota.Text);
        }

        private void SaveEntity(AlumnoInscripcion alumno)
        {
            new AlumnoInscripcionLogic().Save(alumno);
        }
        private void DeleteEntity(int ID)
        {
            new AlumnoInscripcionLogic().Delete(ID);
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
                    Entity = new AlumnoInscripcion();
                    Entity.ID = SelectedID;
                    Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    LoadGrid();
                    break;
                case FormModes.Alta:
                    Entity = new AlumnoInscripcion();
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