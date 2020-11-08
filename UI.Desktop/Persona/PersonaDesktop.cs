using System;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class PersonaDesktop : ApplicationForm
    {
        public PersonaDesktop()
        {
            InitializeComponent();
            comboBoxTipoPersona.DataSource = Enum.GetNames(typeof(Persona.TiposPersonas));
            comboBoxTipoPersona.SelectedItem = Persona.TiposPersonas.Alumno;
        }
        public PersonaDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public Persona PersonaActual { get; set; }
        public PersonaDesktop(int ID, ModoForm modo) : this(modo)
        {
            this.PersonaActual = new PersonaLogic().GetOne(ID);
            MapearDeDatos();
        }
        /// <summary>
        /// Copia información de las entidades a los controles del formulario para nostrar la información de cada entidad.
        /// </summary>
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.PersonaActual.ID.ToString();
            this.txtNombre.Text = this.PersonaActual.Nombre.ToString();
            this.textApellido.Text = this.PersonaActual.Apellido.ToString();
            this.txtDireccion.Text = this.PersonaActual.Direccion.ToString();
            this.txtTelefono.Text = this.PersonaActual.Telefono.ToString();
            this.DTPFechaNac.Text = this.PersonaActual.FechaNacimiento.ToString();
            this.txtLegajo.Text = this.PersonaActual.Legajo.ToString();
            this.comboBoxTipoPersona.Text = this.PersonaActual.TipoPersona.ToString();
            this.comboBoxIDPlan.Text = this.PersonaActual.IDPlan.ToString();

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
                if (this.Modo == ModoForm.Alta) this.PersonaActual = new Persona();
                else this.PersonaActual.ID = int.Parse(this.txtID.Text);

                this.PersonaActual.Nombre = this.txtNombre.Text;
                this.PersonaActual.Apellido = this.textApellido.Text;
                this.PersonaActual.Direccion = this.txtDireccion.Text;
                this.PersonaActual.Telefono = this.txtTelefono.Text;
                this.PersonaActual.FechaNacimiento = this.DTPFechaNac.Value;
                this.PersonaActual.Legajo = int.Parse(this.txtLegajo.Text);
                Enum.TryParse<Persona.TiposPersonas>(this.comboBoxTipoPersona.SelectedValue.ToString(), out Persona.TiposPersonas tipo_persona);
                this.PersonaActual.TipoPersona = tipo_persona;
                this.PersonaActual.IDPlan = int.Parse(this.comboBoxIDPlan.Text);

                switch (Modo)
                {
                    case ModoForm.Alta:
                        {
                            PersonaActual.State = BusinessEntity.States.New;
                            break;
                        }
                    case ModoForm.Baja:
                        {
                            PersonaActual.State = BusinessEntity.States.Deleted;
                            break;
                        }
                    case ModoForm.Consulta:
                        {
                            PersonaActual.State = BusinessEntity.States.Unmodified;
                            break;
                        }
                    case ModoForm.Modificacion:
                        {
                            PersonaActual.State = BusinessEntity.States.Modified;
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
                        new PersonaLogic().Save(PersonaActual);
                        break;
                    }
                case ModoForm.Baja:
                    {
                        new PersonaLogic().Delete(PersonaActual.ID);
                        break;
                    }
                default: break;
            }
        }
        /// <summary>
        /// Valida datos para poder registrar los cambios realizados.
        /// </summary>
        /// <returns>Validez de datos</returns>
        public override bool Validar()
        {
            if (!string.IsNullOrEmpty(this.txtNombre.Text) && !string.IsNullOrEmpty(this.textApellido.Text) &&
                 !string.IsNullOrEmpty(this.txtDireccion.Text) && !string.IsNullOrEmpty(this.txtLegajo.Text) &&
                  !string.IsNullOrEmpty(this.txtTelefono.Text)) return true;
            else {
                Notificar("Error", "Ingreso de datos inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void PersonaDesktop_Load(object sender, EventArgs e)
        {
            ListarPlanes();
        }

        private void ListarPlanes()
        {
            foreach (Plan plan in new PlanLogic().GetAll())
            {
                comboBoxIDPlan.Items.Add(plan.ID.ToString());
            }
            try
            {
                comboBoxIDPlan.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha encontrado ningun plan cargado", "DocenteCurso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
