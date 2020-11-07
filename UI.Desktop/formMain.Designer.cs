namespace UI.Desktop
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListado = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlanes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuComisiones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoInscripcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCursosPorDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCursosAprobadosPorAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo,
            this.mnuListado,
            this.mnuReportes});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mnsPrincipal.TabIndex = 1;
            this.mnsPrincipal.Text = "menuStrip1";
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(60, 20);
            this.mnuArchivo.Text = "Archivo";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(96, 22);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // mnuListado
            // 
            this.mnuListado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuarios,
            this.mnuMaterias,
            this.mnuPlanes,
            this.mnuEspecialidades,
            this.mnuComisiones,
            this.mnuPersonas,
            this.cursosToolStripMenuItem,
            this.alumnoInscripcionToolStripMenuItem,
            this.docenteCursoToolStripMenuItem});
            this.mnuListado.Name = "mnuListado";
            this.mnuListado.Size = new System.Drawing.Size(57, 20);
            this.mnuListado.Text = "Listado";
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(178, 22);
            this.mnuUsuarios.Text = "Usuarios";
            this.mnuUsuarios.Click += new System.EventHandler(this.mnuUsuarios_Click);
            // 
            // mnuMaterias
            // 
            this.mnuMaterias.Name = "mnuMaterias";
            this.mnuMaterias.Size = new System.Drawing.Size(178, 22);
            this.mnuMaterias.Text = "Materias";
            this.mnuMaterias.Click += new System.EventHandler(this.mnuMaterias_Click);
            // 
            // mnuPlanes
            // 
            this.mnuPlanes.Name = "mnuPlanes";
            this.mnuPlanes.Size = new System.Drawing.Size(178, 22);
            this.mnuPlanes.Text = "Planes";
            this.mnuPlanes.Click += new System.EventHandler(this.mnuPlanes_Click);
            // 
            // mnuEspecialidades
            // 
            this.mnuEspecialidades.Name = "mnuEspecialidades";
            this.mnuEspecialidades.Size = new System.Drawing.Size(178, 22);
            this.mnuEspecialidades.Text = "Especialidades";
            this.mnuEspecialidades.Click += new System.EventHandler(this.mnuEspecialidades_Click);
            // 
            // mnuComisiones
            // 
            this.mnuComisiones.Name = "mnuComisiones";
            this.mnuComisiones.Size = new System.Drawing.Size(178, 22);
            this.mnuComisiones.Text = "Comisiones";
            this.mnuComisiones.Click += new System.EventHandler(this.mnuComisiones_Click);
            // 
            // mnuPersonas
            // 
            this.mnuPersonas.Name = "mnuPersonas";
            this.mnuPersonas.Size = new System.Drawing.Size(178, 22);
            this.mnuPersonas.Text = "Personas";
            this.mnuPersonas.Click += new System.EventHandler(this.personasToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cursosToolStripMenuItem.Text = "Cursos";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // alumnoInscripcionToolStripMenuItem
            // 
            this.alumnoInscripcionToolStripMenuItem.Name = "alumnoInscripcionToolStripMenuItem";
            this.alumnoInscripcionToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.alumnoInscripcionToolStripMenuItem.Text = "Alumno Inscripción";
            this.alumnoInscripcionToolStripMenuItem.Click += new System.EventHandler(this.alumnoInscripcionToolStripMenuItem_Click);
            // 
            // docenteCursoToolStripMenuItem
            // 
            this.docenteCursoToolStripMenuItem.Name = "docenteCursoToolStripMenuItem";
            this.docenteCursoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.docenteCursoToolStripMenuItem.Text = "Docente Curso";
            this.docenteCursoToolStripMenuItem.Click += new System.EventHandler(this.docenteCursoToolStripMenuItem_Click);
            // 
            // mnuReportes
            // 
            this.mnuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCursosPorDocente,
            this.mnuCursosAprobadosPorAlumno});
            this.mnuReportes.Name = "mnuReportes";
            this.mnuReportes.Size = new System.Drawing.Size(65, 20);
            this.mnuReportes.Text = "Reportes";
            // 
            // mnuCursosPorDocente
            // 
            this.mnuCursosPorDocente.Name = "mnuCursosPorDocente";
            this.mnuCursosPorDocente.Size = new System.Drawing.Size(238, 22);
            this.mnuCursosPorDocente.Text = "Cursos por Docente";
            this.mnuCursosPorDocente.Click += new System.EventHandler(this.mnuCursosPorDocente_Click);
            // 
            // mnuCursosAprobadosPorAlumno
            // 
            this.mnuCursosAprobadosPorAlumno.Name = "mnuCursosAprobadosPorAlumno";
            this.mnuCursosAprobadosPorAlumno.Size = new System.Drawing.Size(238, 22);
            this.mnuCursosAprobadosPorAlumno.Text = "Cursos Aprobados por Alumno";
            this.mnuCursosAprobadosPorAlumno.Click += new System.EventHandler(this.mnuCursosAprobadosPorAlumno_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnsPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsPrincipal;
            this.Name = "formMain";
            this.Text = "Academia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.formMain_Shown);
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuListado;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuMaterias;
        private System.Windows.Forms.ToolStripMenuItem mnuPlanes;
        private System.Windows.Forms.ToolStripMenuItem mnuEspecialidades;
        private System.Windows.Forms.ToolStripMenuItem mnuComisiones;
        private System.Windows.Forms.ToolStripMenuItem mnuPersonas;
        private System.Windows.Forms.ToolStripMenuItem alumnoInscripcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docenteCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuReportes;
        private System.Windows.Forms.ToolStripMenuItem mnuCursosPorDocente;
        private System.Windows.Forms.ToolStripMenuItem mnuCursosAprobadosPorAlumno;
    }
}