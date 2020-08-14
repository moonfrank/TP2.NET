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
    public partial class DocenteCursoDesktop : ApplicationForm
    {
        public DocenteCursoDesktop()
        {          
            InitializeComponent();
            cbxCargo.DataSource = Enum.GetNames(typeof(DocenteCurso.TiposCargos));
        }
        public DocenteCursoDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public DocenteCursoDesktop(int ID, ModoForm modo) : this(modo)
        {
            this.DocenteCursoActual = new DocenteCursoLogic().GetOne(ID);
            MapearDeDatos();
        }

        public DocenteCurso DocenteCursoActual { get; set; }

        /// <summary>
        /// Copia información de las entidades a los controles del formulario para nostrar la información de cada entidad.
        /// </summary>
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.DocenteCursoActual.ID.ToString();
            this.cbxCargo.Text = DocenteCursoActual.Cargo.ToString();
            this.cboxIDCurso.Text = this.DocenteCursoActual.IDCurso.ToString();
            this.cboxIDDocente.Text = this.DocenteCursoActual.IDDocente.ToString();


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
                if (this.Modo == ModoForm.Alta) this.DocenteCursoActual = new DocenteCurso();
                else this.DocenteCursoActual.ID = int.Parse(this.txtID.Text);

                this.txtID.Text = this.DocenteCursoActual.ID.ToString();
                this.cbxCargo.Text = DocenteCursoActual.Cargo.ToString();
                this.cboxIDCurso.Text = this.DocenteCursoActual.IDCurso.ToString();
                this.cboxIDDocente.Text = this.DocenteCursoActual.IDDocente.ToString();

                switch (Modo)
                {
                    case ModoForm.Alta:
                        {
                            DocenteCursoActual.State = BusinessEntity.States.New;
                            break;
                        }
                    case ModoForm.Baja:
                        {
                            DocenteCursoActual.State = BusinessEntity.States.Deleted;
                            break;
                        }
                    case ModoForm.Consulta:
                        {
                            DocenteCursoActual.State = BusinessEntity.States.Unmodified;
                            break;
                        }
                    case ModoForm.Modificacion:
                        {
                            DocenteCursoActual.State = BusinessEntity.States.Modified;
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
                        new DocenteCursoLogic().Save(DocenteCursoActual);
                        break;
                    }
                case ModoForm.Baja:
                    {
                        new DocenteCursoLogic().Delete(DocenteCursoActual.ID);
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
                Regex.IsMatch(this.txtEmail.Text, expresion) && Regex.Replace(this.txtEmail.Text, expresion, string.Empty).Length == 0 &&
            !string.IsNullOrEmpty(this.txtNombre.Text) && !string.IsNullOrEmpty(this.txtApellido.Text) && !string.IsNullOrEmpty(this.txtUsuario.Text)) return true;
            else
            {
                Notificar("Error", "Ingreso de datos inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }*/
            return true;
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

        private void CursoDesktop_Load(object sender, EventArgs e)
        {
            ListarCBX();
        }

        private void ListarCBX()
        {
            foreach (Curso curso in new CursoLogic().GetAll())
            {
                cboxIDCurso.Items.Add(curso.ID.ToString());
            }
            try
            {
                cboxIDCurso.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha encontrado ningun curso cargado", "DocenteCurso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            var profesor = from p in new PersonaLogic().GetAll()
                         where p.TipoPersona.ToString() == "Profesor"
                         select p;
            foreach (Persona persona in profesor)
            {
                cboxIDDocente.Items.Add(persona.ID.ToString());
            }
            try
            {
                cboxIDDocente.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha encontrado ningun profesor cargado", "DocenteCurso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            
        }
    }
}
