using System;
using System.Windows.Forms;
using UI.Desktop.Reportes;

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
            if (session.tipoPersona.ToString() != "Admin")
            {
                this.mnuEspecialidades.Enabled = false;
                this.mnuPersonas.Enabled = false;
                this.mnuPlanes.Enabled = false;
            }
            if (session.tipoPersona.ToString() == "Alumno")
            {
                this.mnuCursosPorDocente.Enabled = false;
            }
            if (session.tipoPersona.ToString() == "Profesor")
            {
                this.mnuCursosAprobadosPorAlumno.Enabled = false;
            }
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

        private void docenteCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formListaDocenteCurso appDocenteCurso = new formListaDocenteCurso();
            if (appDocenteCurso.ShowDialog() != DialogResult.OK) appDocenteCurso.Dispose();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formListaCursos appListaCursos = new formListaCursos();
            if (appListaCursos.ShowDialog() != DialogResult.OK) appListaCursos.Dispose();
        }

        private void mnuCursosPorDocente_Click(object sender, EventArgs e)
        {
            formReporteCursosDocente appReporteCursos = new formReporteCursosDocente();
            if (appReporteCursos.ShowDialog() != DialogResult.OK) appReporteCursos.Dispose();
        }

        private void mnuCursosAprobadosPorAlumno_Click(object sender, EventArgs e)
        {
            formReporteMateriasAlumno appReporteMaterias = new formReporteMateriasAlumno();
            if (appReporteMaterias.ShowDialog() != DialogResult.OK) appReporteMaterias.Dispose();
        }
    }
}
