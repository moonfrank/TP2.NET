using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        public UsuarioDesktop()
        {
            InitializeComponent();
        }

        public UsuarioDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public UsuarioDesktop(int ID, ModoForm modo) : this(modo)
        {
            this.UsuarioActual = new UsuarioLogic().GetOne(ID);
            MapearDeDatos();
        }

        public Usuario UsuarioActual { get; set; }

        /// <summary>
        /// Copia información de las entidades a los controles del formulario para nostrar la información de cada entidad.
        /// </summary>
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtEmail.Text = this.UsuarioActual.Email;
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
                if (this.Modo == ModoForm.Alta) this.UsuarioActual = new Usuario();
                else this.UsuarioActual.ID = int.Parse(this.txtID.Text);

                this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                this.UsuarioActual.Nombre = this.txtNombre.Text;
                this.UsuarioActual.Apellido = this.txtApellido.Text;
                this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                this.UsuarioActual.Clave = this.txtClave.Text;
                this.UsuarioActual.Email = this.txtEmail.Text;

                switch (Modo)
                {
                    case ModoForm.Alta:
                        {
                            UsuarioActual.State = BusinessEntity.States.New;
                            break;
                        }
                    case ModoForm.Baja:
                        {
                            UsuarioActual.State = BusinessEntity.States.Deleted;
                            break;
                        }
                    case ModoForm.Consulta:
                        {
                            UsuarioActual.State = BusinessEntity.States.Unmodified;
                            break;
                        }
                    case ModoForm.Modificacion:
                        {
                            UsuarioActual.State = BusinessEntity.States.Modified;
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
                        new UsuarioLogic().Save(UsuarioActual);
                        break;
                    }
                case ModoForm.Baja:
                    {
                        new UsuarioLogic().Delete(UsuarioActual.ID);
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
            if (this.txtClave.Text.Equals(this.txtConfirm.Text) && txtClave.Text.Length >= 8 && Validation.IsEmailValid(txtEmail.Text) &&
            !string.IsNullOrEmpty(this.txtNombre.Text) && !string.IsNullOrEmpty(this.txtApellido.Text) && !string.IsNullOrEmpty(this.txtUsuario.Text)) return true;
            else
            {
                Notificar("Error", "Ingreso de datos inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsuarioDesktop_Load(object sender, EventArgs e)
        {
            ListarCBX();
        }

        private void ListarCBX()
        {
            foreach (Persona persona in new PersonaLogic().GetAll())
            {
                cmbxIDPersona.Items.Add(persona.ID.ToString());
            }
            try
            {
                cmbxIDPersona.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha encontrado ninguna persona cargada", "Persona", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            finally
            {
                Persona persona = new PersonaLogic().GetOne(Convert.ToInt32(cmbxIDPersona.SelectedItem));
                txtNombre.Text = persona.Nombre;
                txtApellido.Text = persona.Apellido;
            }
        }
        private void cmbxIDPersona_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Persona persona = new PersonaLogic().GetOne(Convert.ToInt32(cmbxIDPersona.SelectedItem));
            txtNombre.Text = persona.Nombre;
            txtApellido.Text = persona.Apellido;
        }
    }
}
