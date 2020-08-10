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
    public partial class formMain : ApplicationForm
    {
        public formMain()
        {
            InitializeComponent();
        }
        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void formMain_Shown(object sender, EventArgs e)
        {
            formLogin appLogin = new formLogin();
            if (appLogin.ShowDialog() != DialogResult.OK) this.Dispose();
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            formListaUsuarios appListaUsuarios = new formListaUsuarios();
            if (appListaUsuarios.ShowDialog() != DialogResult.OK) appListaUsuarios.Dispose();
        }

        private void mnuMaterias_Click(object sender, EventArgs e)
        {
            formListaMaterias appListaMaterias = new formListaMaterias();
            if (appListaMaterias.ShowDialog() != DialogResult.OK) appListaMaterias.Dispose();
        }

        private void mnuEspecialidades_Click(object sender, EventArgs e)
        {
            formListaEspecialidades appListaEspecialidades = new formListaEspecialidades();
            if (appListaEspecialidades.ShowDialog() != DialogResult.OK) appListaEspecialidades.Dispose();
        }

        private void mnuPlanes_Click(object sender, EventArgs e)
        {
            formListaPlanes appListaPlanes = new formListaPlanes();
            if (appListaPlanes.ShowDialog() != DialogResult.OK) appListaPlanes.Dispose();
        }

        private void mnuComisiones_Click(object sender, EventArgs e)
        {
            formListaComisiones appListaComisiones = new formListaComisiones();
            if (appListaComisiones.ShowDialog() != DialogResult.OK) appListaComisiones.Dispose();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formListaPersona appListaPersonas = new formListaPersona();
            if (appListaPersonas.ShowDialog() != DialogResult.OK) appListaPersonas.Dispose();
        }

        private void alumnoInscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formListaAlumnoInscripcion appAlumnoInscripcion = new formListaAlumnoInscripcion();
            if (appAlumnoInscripcion.ShowDialog() != DialogResult.OK) appAlumnoInscripcion.Dispose();
        }
    }
}
