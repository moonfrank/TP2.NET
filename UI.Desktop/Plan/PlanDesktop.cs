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
    public partial class PlanDesktop : ApplicationForm
    {
        public PlanDesktop()
        {
            InitializeComponent();
        }

        public PlanDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public PlanDesktop(int ID, ModoForm modo) : this(modo)
        {
            this.PlanActual = new PlanLogic().GetOne(ID);
            MapearDeDatos();
        }

        public Plan PlanActual { get; set; }

        /// <summary>
        /// Copia información de las entidades a los controles del formulario para nostrar la información de cada entidad.
        /// </summary>
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.PlanActual.ID.ToString();
            this.txtDescripcion.Text = this.PlanActual.Descripcion;
            this.cboxIDEspecialidad.Text = this.PlanActual.IDEspecialidad.ToString();
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
                if (this.Modo == ModoForm.Alta) this.PlanActual = new Plan();
                else this.PlanActual.ID = int.Parse(this.txtID.Text);

                this.PlanActual.Descripcion = this.txtDescripcion.Text;
                this.PlanActual.IDEspecialidad = int.Parse(this.cboxIDEspecialidad.Text);

                switch (Modo)
                {
                    case ModoForm.Alta:
                        {
                            PlanActual.State = BusinessEntity.States.New;
                            break;
                        }
                    case ModoForm.Baja:
                        {
                            PlanActual.State = BusinessEntity.States.Deleted;
                            break;
                        }
                    case ModoForm.Consulta:
                        {
                            PlanActual.State = BusinessEntity.States.Unmodified;
                            break;
                        }
                    case ModoForm.Modificacion:
                        {
                            PlanActual.State = BusinessEntity.States.Modified;
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
                        new PlanLogic().Save(PlanActual);
                        break;
                    }
                case ModoForm.Baja:
                    {
                        new PlanLogic().Delete(PlanActual.ID);
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
            /*
            if (this.txtClave.Text.Equals(this.txtConfirm.Text) && txtClave.Text.Length >= 8 &&
                Regex.IsMatch(this.txtEmail.Text, expresion) && Regex.Replace(this.txtEmail.Text, expresion, string.Empty).Length == 0 &&
            !string.IsNullOrEmpty(this.txtNombre.Text) && !string.IsNullOrEmpty(this.txtApellido.Text) && !string.IsNullOrEmpty(this.txtUsuario.Text)) return true;
            else
            {
                Notificar("Error", "Ingreso de datos inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            */
            return true;
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
    }


}
