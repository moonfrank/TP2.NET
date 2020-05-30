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
    public partial class ApplicationForm : Form
    {
        public enum ModoForm
        {
            Alta,
            Baja,
            Modificacion,
            Consulta
        }
        public ApplicationForm()
        {
            InitializeComponent();
        }

        public ModoForm Modo { get; set; }

        /// <summary>
        /// Copia información de las entidades a los controles del formulario para nostrar la información de cada entidad.
        /// </summary>
        public virtual void MapearDeDatos() { }
        /// <summary>
        /// Pasa la información de los controles a una entidad para enviarla a la capas inferiores.
        /// </summary>
        public virtual void MapearADatos() { }
        /// <summary>
        /// Invoca al método correspondiente de la capa de negocio según Modo.
        /// </summary>
        public virtual void GuardarCambios() { }
        /// <summary>
        /// Valida datos para poder registrar los cambios realizados.
        /// </summary>
        /// <returns>Validez de datos</returns>
        public virtual bool Validar() { return false; }
        /// <summary>
        /// Avisos al usuario.
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="mensaje"></param>
        /// <param name="botones"></param>
        /// <param name="icono"></param>
        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }

    }
}
