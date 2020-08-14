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
    public partial class EspecialidadesDesktop : ApplicationForm
    {
        public Especialidad EspecialidadActual { get; set; }
        public EspecialidadesDesktop()
        {
            InitializeComponent();
        }
        public EspecialidadesDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }
        public EspecialidadesDesktop(int ID, ModoForm modo) : this(modo)
        {
            this.EspecialidadActual = new EspecialidadLogic().GetOne(ID);
            MapearDeDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Valida()
        {
            if (!string.IsNullOrEmpty(this.txtDescripcion.Text))
            {
                return true;
            }
            else
            {
                Notificar("Error", "Ingreso de datos inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.EspecialidadActual.ID.ToString();
            txtDescripcion.Text = EspecialidadActual.Descripcion.ToString();
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
        public override void GuardarCambios()
        {
            MapearADatos();
            switch (this.Modo)
            {
                case ModoForm.Alta:
                case ModoForm.Modificacion:
                    {
                        new EspecialidadLogic().Save(EspecialidadActual);
                        break;
                    }
                case ModoForm.Baja:
                    {
                        new EspecialidadLogic().Delete(EspecialidadActual.ID);
                        break;
                    }
                default: break;
            }
        }
        public override void MapearADatos()
        {
            if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion)
            {
                if (this.Modo == ModoForm.Alta) this.EspecialidadActual = new Especialidad();
                else this.EspecialidadActual.ID = int.Parse(this.txtID.Text);
                this.EspecialidadActual.Descripcion = this.txtDescripcion.Text;
                switch (Modo)
                {
                    case ModoForm.Alta:
                        {
                            EspecialidadActual.State = BusinessEntity.States.New;
                            break;
                        }
                    case ModoForm.Baja:
                        {
                            EspecialidadActual.State = BusinessEntity.States.Deleted;
                            break;
                        }
                    case ModoForm.Consulta:
                        {
                            EspecialidadActual.State = BusinessEntity.States.Unmodified;
                            break;
                        }
                    case ModoForm.Modificacion:
                        {
                            EspecialidadActual.State = BusinessEntity.States.Modified;
                            break;
                        }
                }
            }
        }
    }
}
