using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class AlumnoInscripcionDesktop : UI.Desktop.ApplicationForm
    {
        public AlumnoInscripcionDesktop()
        {
            InitializeComponent();
        }

        private void AlumnoInscripcion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_AcademiaDataSet_NOEXPRESS_.cursos' Puede moverla o quitarla según sea necesario.
            this.cursosTableAdapter.Fill(this._AcademiaDataSet_NOEXPRESS_.cursos);

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

        public AlumnoInscripcion AlumnoInscripcionActual { get; set; }

        /// <summary>
        /// Copia información de las entidades a los controles del formulario para nostrar la información de cada entidad.
        /// </summary>
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.AlumnoInscripcionActual.ID.ToString();
            cbxIDAlumno.Text = AlumnoInscripcionActual.IDAlumno.ToString();
            cbxIDCurso.Text = AlumnoInscripcionActual.IDCurso.ToString();
            this.txtCondicion.Text = this.AlumnoInscripcionActual.Condicion;
            this.txtNota.Text = this.AlumnoInscripcionActual.Nota.ToString();
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
                if (this.Modo == ModoForm.Alta) this.AlumnoInscripcionActual = new AlumnoInscripcion();
                else this.AlumnoInscripcionActual.ID = int.Parse(this.txtID.Text);

                this.AlumnoInscripcionActual.IDAlumno = int.Parse(this.cbxIDAlumno.Text);
                this.AlumnoInscripcionActual.IDCurso = int.Parse(this.cbxIDCurso.Text);
                this.AlumnoInscripcionActual.Condicion = this.txtCondicion.Text;
                this.AlumnoInscripcionActual.Nota = int.Parse(this.txtNota.Text);

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
        public override bool Validar()
        {
            //string expresion = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            //if (this.txtClave.Text.Equals(this.txtConfirm.Text) && txtClave.Text.Length >= 8 &&
            //    Regex.IsMatch(this.txtEmail.Text, expresion) && Regex.Replace(this.txtEmail.Text, expresion, string.Empty).Length == 0 &&
            //!string.IsNullOrEmpty(this.txtNombre.Text) && !string.IsNullOrEmpty(this.txtApellido.Text) && !string.IsNullOrEmpty(this.txtUsuario.Text)) return true;
            //else
            //{
            //    Notificar("Error", "Ingreso de datos inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            return true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
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
