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

        public virtual void MapearDeDatos() { }
        
        public virtual void MapearADatos() { }
        
        public virtual void GuardarCambios() { }
       
        public virtual bool Validar() { return false; }
        /// <summary>
        /// Avisos al usuario.
        /// </summary>
        /// <param name="titulo"> Título de la ventana </param>
        /// <param name="mensaje"> Mensaje de la ventana </param>
        /// <param name="botones"> Botones que tendrá la ventana </param>
        /// <param name="icono"> Ícono que tendrá la ventana </param>
        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        /// <summary>
        /// Avisos al usuario.
        /// </summary>
        /// <param name="mensaje"> Mensaje de la ventana </param>
        /// <param name="botones"> Botones que tendrá la ventana </param>
        /// <param name="icono"> Ícono que tendrá la ventana </param>
        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }

    }
}
