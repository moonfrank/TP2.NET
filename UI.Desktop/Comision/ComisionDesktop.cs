using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class ComisionDesktop : ApplicationForm
    {
        public ComisionDesktop()
        {
            InitializeComponent();
        }

        public ComisionDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public ComisionDesktop(int ID, ModoForm modo) : this(modo)
        {
            this.ComisionActual = new ComisionLogic().GetOne(ID);
            MapearDeDatos();
        }

        public Comision ComisionActual { get; set; }

        /// <summary>
        /// Copia información de las entidades a los controles del formulario para nostrar la información de cada entidad.
        /// </summary>
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.ComisionActual.ID.ToString();
            this.txtDescripcion.Text = this.ComisionActual.Descripcion;
            this.cboxIDPlan.Text = this.ComisionActual.IDPlan.ToString();
            this.txtAnioEspecialidad.Text = this.ComisionActual.AnioEspecialidad.ToString();
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
                if (this.Modo == ModoForm.Alta) this.ComisionActual = new Comision();
                else this.ComisionActual.ID = int.Parse(this.txtID.Text);

                this.ComisionActual.Descripcion = this.txtDescripcion.Text;
                this.ComisionActual.IDPlan = int.Parse(this.cboxIDPlan.Text);
                this.ComisionActual.AnioEspecialidad = int.Parse(this.txtAnioEspecialidad.Text);

                switch (Modo)
                {
                    case ModoForm.Alta:
                        {
                            ComisionActual.State = BusinessEntity.States.New;
                            break;
                        }
                    case ModoForm.Baja:
                        {
                            ComisionActual.State = BusinessEntity.States.Deleted;
                            break;
                        }
                    case ModoForm.Consulta:
                        {
                            ComisionActual.State = BusinessEntity.States.Unmodified;
                            break;
                        }
                    case ModoForm.Modificacion:
                        {
                            ComisionActual.State = BusinessEntity.States.Modified;
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
                        new ComisionLogic().Save(ComisionActual);
                        break;
                    }
                case ModoForm.Baja:
                    {
                        new ComisionLogic().Delete(ComisionActual.ID);
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
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (cboxIDPlan.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccionar un plan!"); return;
                }
                else if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor completar la descripción!"); return;
                }
                else if (string.IsNullOrEmpty(txtAnioEspecialidad.Text))
                {
                    MessageBox.Show("Por favor especificar un año!"); return;
                }
                else if (0 > int.Parse(txtAnioEspecialidad.Text) || int.Parse(txtAnioEspecialidad.Text) > 9)
                {
                    MessageBox.Show("El año de la especialidad no tiene que ser menor que 0 ni mayor que 9!"); return;
                }
                else 
                {
                    GuardarCambios();
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComisionDesktop_Load(object sender, EventArgs e)
        {
            ListarPlan();
        }
        private void ListarPlan()
        {
            foreach (Plan plan in new PlanLogic().GetAll())
            {
                cboxIDPlan.Items.Add(plan.ID.ToString());
            }
            try
            {
                cboxIDPlan.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha encontrado ningun plan cargado", "DocenteCurso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
