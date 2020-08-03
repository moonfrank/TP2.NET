using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class EspecialidadesDesktop : ApplicationForm
    {
        public Especialidad EspecialidadActual { get; set; }
        public EspecialidadesDesktop()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                GuardarCambios();
                this.Close();
            }
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
                        new UsuarioLogic().Delete(EspecialidadActual.ID);
                        break;
                    }
                default: break;
            }
        }
    }
}
