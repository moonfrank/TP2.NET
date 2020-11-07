using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class AlumnoInscripcionDesktop : ApplicationForm
    {
        public AlumnoInscripcionDesktop()
        {
            InitializeComponent();
        }

        public AlumnoInscripcionDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public AlumnoInscripcionDesktop(int ID, ModoForm modo) : this(modo)
        {
            this.AlumnoInscripcionActual = new AlumnoInscripcionLogic().GetOne(ID);
            MapearDeDatos();
        }

        public Business.Entities.AlumnoInscripcion AlumnoInscripcionActual { get; set; }

        /// <summary>
        /// Copia información de las entidades a los controles del formulario para nostrar la información de cada entidad.
        /// </summary>
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.AlumnoInscripcionActual.ID.ToString();
            cbxIDAlumno.Text = AlumnoInscripcionActual.IDAlumno.ToString();
            cbxIDCurso.Text = AlumnoInscripcionActual.IDCurso.ToString();
            this.cbxCondicion.Text = this.AlumnoInscripcionActual.Condicion;
            if (this.AlumnoInscripcionActual.Condicion == "Aprobado")
            {
                this.txtNota.Text = this.AlumnoInscripcionActual.Nota.ToString();
                if (session.tipoPersona != Persona.TiposPersonas.Alumno)
                    this.txtNota.Enabled = true;
            }
                
            else
                this.txtNota.Text = string.Empty;
            switch (this.Modo)
            {
                case ModoForm.Alta:
                case ModoForm.Modificacion:
                    {
                        btnAceptar.Text = "Guardar";
                        break;
                    }
                case ModoForm.Baja:
                    {
                        btnAceptar.Text = "Eliminar";
                        break;
                    }
                default:
                    {
                        btnAceptar.Text = "Aceptar";
                        break;
                    }
            }
        }
        /// <summary>
        /// Pasa la información de los controles a una entidad para enviarla a la capas inferiores.
        /// </summary>
        public override void MapearADatos()
        {
            if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion)
            {
                if (this.Modo == ModoForm.Alta)
                    this.AlumnoInscripcionActual = new AlumnoInscripcion();
                else
                {
                    this.AlumnoInscripcionActual.ID = int.Parse(this.txtID.Text);
                    this.AlumnoInscripcionActual.Nota = int.Parse(this.txtNota.Text);
                }

                this.AlumnoInscripcionActual.IDAlumno = int.Parse(this.cbxIDAlumno.Text);
                this.AlumnoInscripcionActual.IDCurso = int.Parse(this.cbxIDCurso.Text);
                this.AlumnoInscripcionActual.Condicion = this.cbxCondicion.Text;
                

                switch (Modo)
                {
                    case ModoForm.Alta:
                        {
                            AlumnoInscripcionActual.State = BusinessEntity.States.New;
                            break;
                        }
                    case ModoForm.Baja:
                        {
                            AlumnoInscripcionActual.State = BusinessEntity.States.Deleted;
                            break;
                        }
                    case ModoForm.Consulta:
                        {
                            AlumnoInscripcionActual.State = BusinessEntity.States.Unmodified;
                            break;
                        }
                    case ModoForm.Modificacion:
                        {
                            AlumnoInscripcionActual.State = BusinessEntity.States.Modified;
                            break;
                        }
                }
            }
        }
        /// <summary>
        /// Invoca al método correspondiente de la capa de negocio según Modo.
        /// </summary>
        public override void GuardarCambios()
        {
            MapearADatos();
            switch (this.Modo)
            {
                case ModoForm.Alta:
                case ModoForm.Modificacion:
                    {
                        new AlumnoInscripcionLogic().Save(AlumnoInscripcionActual);
                        break;
                    }
                case ModoForm.Baja:
                    {
                        new AlumnoInscripcionLogic().Delete(AlumnoInscripcionActual.ID);
                        break;
                    }
                default: break;
            }
        }
        /// <summary>
        /// Valida datos para poder registrar los cambios realizados.
        /// </summary>
        /// <returns>Validez de datos</returns>

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cbxIDAlumno.SelectedIndex == -1)
                MessageBox.Show("Por favor seleccionar un alumno!");
            else if (cbxIDCurso.SelectedIndex == -1)
                MessageBox.Show("Por favor seleccionar un curso!");
            else if (string.IsNullOrWhiteSpace(cbxCondicion.Text))
                MessageBox.Show("Por favor especificar la condición!");
            else if (cbxCondicion.Text == "Aprobado")
            {
                if (string.IsNullOrWhiteSpace(txtNota.Text))
                    MessageBox.Show("Por favor especificar la nota!");
                else if (int.TryParse(txtNota.Text, out int a))
                    if (int.Parse(txtNota.Text) < 1 || int.Parse(txtNota.Text) > 10)
                        MessageBox.Show("La nota tiene que ser un número entre entre 1 y 10!");
            }
            else
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void AlumnoInscripcionDesktop_Load(object sender, EventArgs e)
        {
            if (session.tipoPersona != Persona.TiposPersonas.Admin)
                cbxIDAlumno.Enabled = false;
            if (session.tipoPersona == Persona.TiposPersonas.Alumno)
                cbxCondicion.Enabled = false;
            txtNota.Enabled = false;
            ListarCmbx();
        }

        private void ListarCmbx()
        {
            foreach (Curso curso in new CursoLogic().GetAll())
            {
                cbxIDCurso.Items.Add(curso.ID.ToString());
            }
            try
            {
                cbxIDCurso.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha encontrado ningun curso cargado", "DocenteCurso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            var alumno = from a in new PersonaLogic().GetAll()
                         where a.TipoPersona.ToString() == "Alumno"
                         select a;
            foreach (Persona persona in alumno)
            {
                cbxIDAlumno.Items.Add(persona.ID.ToString());
            }
            try
            {
                cbxIDAlumno.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha encontrado ningun alumno cargado", "DocenteCurso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            cbxCondicion.Items.Add("Libre");
            cbxCondicion.Items.Add("Cursa");
            cbxCondicion.Items.Add("Regular");
            cbxCondicion.Items.Add("Aprobado");
            cbxCondicion.SelectedIndex = 1;
        }
        private void cbxCondicion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxCondicion.SelectedItem.ToString() == "Aprobado")
                this.txtNota.Enabled = true;
            else
                this.txtNota.Enabled = false;
        }
    }
}
