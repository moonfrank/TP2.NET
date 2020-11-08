using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class CursoDesktop : ApplicationForm
    {
        public CursoDesktop()
        {
            List<int> anios = Enumerable.Range(1950, DateTime.UtcNow.AddYears(5).Year - 1949).ToList();
            InitializeComponent();
            cboxAnioCalendario.DataSource = anios;
        }

        public CursoDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public CursoDesktop(int ID, ModoForm modo) : this(modo)
        {
            this.CursoActual = new CursoLogic().GetOne(ID);
            MapearDeDatos();
        }

        public Curso CursoActual { get; set; }

        /// <summary>
        /// Copia información de las entidades a los controles del formulario para nostrar la información de cada entidad.
        /// </summary>
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.CursoActual.ID.ToString();
            this.cboxIDMateria.Text = this.CursoActual.IDMateria.ToString();
            this.cboxIDComision.Text = this.CursoActual.IDComision.ToString();
            this.cboxAnioCalendario.Text = this.CursoActual.AnioCalendario.ToString();
            this.txtCupo.Text = this.CursoActual.Cupo.ToString();
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
                if (this.Modo == ModoForm.Alta) this.CursoActual = new Curso();
                else this.CursoActual.ID = int.Parse(this.txtID.Text);

                this.CursoActual.IDMateria = int.Parse(this.cboxIDMateria.Text);
                this.CursoActual.IDComision = int.Parse(this.cboxIDComision.Text);
                this.CursoActual.AnioCalendario = int.Parse(this.cboxAnioCalendario.Text);
                this.CursoActual.Cupo = int.Parse(this.txtCupo.Text);

                switch (Modo)
                {
                    case ModoForm.Alta:
                        {
                            CursoActual.State = BusinessEntity.States.New;
                            break;
                        }
                    case ModoForm.Baja:
                        {
                            CursoActual.State = BusinessEntity.States.Deleted;
                            break;
                        }
                    case ModoForm.Consulta:
                        {
                            CursoActual.State = BusinessEntity.States.Unmodified;
                            break;
                        }
                    case ModoForm.Modificacion:
                        {
                            CursoActual.State = BusinessEntity.States.Modified;
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
                        new CursoLogic().Save(CursoActual);
                        break;
                    }
                case ModoForm.Baja:
                    {
                        new CursoLogic().Delete(CursoActual.ID);
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
            string expresion = @"^[0-9]+$";
            if (Regex.IsMatch(this.txtCupo.Text, expresion) && Regex.Replace(this.txtCupo.Text, expresion, string.Empty).Length == 0) return true;
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
                if (cboxIDMateria.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccionar una materia!"); return;
                }
                else if (cboxIDComision.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccionar una comisión!"); return;
                }
                else if (cboxAnioCalendario.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccionar un año!"); return;
                }
                else if (string.IsNullOrWhiteSpace(txtCupo.Text))
                {
                    MessageBox.Show("Por favor especificar el cupo!"); return;
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

        private void CursoDesktop_Load(object sender, EventArgs e)
        {
            ListarCBX();
        }

        private void ListarCBX()
        {
            foreach (Materia materia in new MateriaLogic().GetAll())
            {
                cboxIDMateria.Items.Add(materia.ID.ToString());
            }
            try
            {
                cboxIDMateria.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha encontrado ninguna materia cargada", "DocenteCurso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            foreach (Comision comision in new ComisionLogic().GetAll())
            {
                cboxIDComision.Items.Add(comision.ID.ToString());
            }
            try
            {
                cboxIDComision.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha encontrado ninguna comision cargada", "DocenteCurso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }        
    }
}
