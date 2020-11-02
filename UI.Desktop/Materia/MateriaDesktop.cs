using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class MateriaDesktop : ApplicationForm
    {
        public MateriaDesktop()
        {
            InitializeComponent();
        }

        public MateriaDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public MateriaDesktop(int ID, ModoForm modo) : this(modo)
        {
            this.MateriaActual = new MateriaLogic().GetOne(ID);
            MapearDeDatos();
        }

        public Materia MateriaActual { get; set; }

        /// <summary>
        /// Copia información de las entidades a los controles del formulario para nostrar la información de cada entidad.
        /// </summary>
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.MateriaActual.ID.ToString();
            this.cboxIDPlan.Text = this.MateriaActual.IDPlan.ToString();
            this.txtDescripcion.Text = this.MateriaActual.Descripcion;
            this.txtHsTotales.Text = this.MateriaActual.HsTotales.ToString();
            this.txtHsSemanales.Text = this.MateriaActual.HsSemanales.ToString();
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
                if (this.Modo == ModoForm.Alta) this.MateriaActual = new Materia();
                else this.MateriaActual.ID = int.Parse(this.txtID.Text);

                this.MateriaActual.IDPlan = int.Parse(this.cboxIDPlan.Text);
                this.MateriaActual.Descripcion = this.txtDescripcion.Text;
                this.MateriaActual.HsTotales = int.Parse(this.txtHsTotales.Text);
                this.MateriaActual.HsSemanales = int.Parse(this.txtHsSemanales.Text);

                switch (Modo)
                {
                    case ModoForm.Alta:
                        {
                            MateriaActual.State = BusinessEntity.States.New;
                            break;
                        }
                    case ModoForm.Baja:
                        {
                            MateriaActual.State = BusinessEntity.States.Deleted;
                            break;
                        }
                    case ModoForm.Consulta:
                        {
                            MateriaActual.State = BusinessEntity.States.Unmodified;
                            break;
                        }
                    case ModoForm.Modificacion:
                        {
                            MateriaActual.State = BusinessEntity.States.Modified;
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
                        new MateriaLogic().Save(MateriaActual);
                        break;
                    }
                case ModoForm.Baja:
                    {
                        new MateriaLogic().Delete(MateriaActual.ID);
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
            /*string expresion = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            if (this.txtClave.Text.Equals(this.txtConfirm.Text) && txtClave.Text.Length >= 8 &&
                Regex.IsMatch(this.txtHsSemanales.Text, expresion) && Regex.Replace(this.txtHsSemanales.Text, expresion, string.Empty).Length == 0 &&
            !string.IsNullOrEmpty(this.txtDescripcion.Text) && !string.IsNullOrEmpty(this.txtApellido.Text) && !string.IsNullOrEmpty(this.txtHsTotales.Text)) return true;
            else
            {
                Notificar("Error", "Ingreso de datos inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }*/
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cboxIDPlan.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccionar un plan!"); return;
            }
            else if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor especificar la descripción!"); return;
            }
            else if (string.IsNullOrWhiteSpace(txtHsSemanales.Text) && !int.TryParse(txtHsSemanales.Text, out int a))
            {
                MessageBox.Show("Por favor especificar las horas semanales!"); return;
            }
            else if (string.IsNullOrWhiteSpace(txtHsTotales.Text) && !int.TryParse(txtHsTotales.Text, out int b))
            {
                MessageBox.Show("Por favor especificar las horas semanales!"); return;
            }
            else
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MateriaDesktop_Load(object sender, EventArgs e)
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

