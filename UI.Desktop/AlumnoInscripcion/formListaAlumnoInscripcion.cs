using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class formListaAlumnoInscripcion : ApplicationForm
    {
        public Business.Entities.AlumnoInscripcion OAlumnoInscripcion { get; set; }
        public formListaAlumnoInscripcion()
        {
            InitializeComponent();
            this.dgvAlumnoInscripcion.AutoGenerateColumns = false;
            if (session.tipoPersona != Persona.TiposPersonas.Admin)
                tsbEliminar.Enabled = false;
            if (session.tipoPersona == Persona.TiposPersonas.Alumno)
                tsbEditar.Enabled = false;
            if (session.tipoPersona == Persona.TiposPersonas.Profesor)
                tsbNuevo.Enabled = false;
        }

        public void Listar()
        {
            this.dgvAlumnoInscripcion.DataSource = new AlumnoInscripcionLogic().GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            new AlumnoInscripcionDesktop(ApplicationForm.ModoForm.Alta).ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvAlumnoInscripcion.SelectedRows.Count!=0)
            {
                new AlumnoInscripcionDesktop(((AlumnoInscripcion)this.dgvAlumnoInscripcion.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Modificacion).ShowDialog();
                this.Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvAlumnoInscripcion.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Está seguro que desea eliminar a esta inscripcion?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    new AlumnoInscripcionDesktop(((AlumnoInscripcion)this.dgvAlumnoInscripcion.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Baja).GuardarCambios();
                    this.Listar();
                }
            }
        }

        private void formListaAlumnoInscripcion_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
