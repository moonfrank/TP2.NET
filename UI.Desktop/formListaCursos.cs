using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class formListaCursos : UI.Desktop.ApplicationForm
    {
        public Cursos OCursos { get; set; }
        public formListaCursos()
        {
            InitializeComponent();
            this.dgvCursos.AutoGenerateColumns = false;
            this.OCursos = new Cursos();
            this.dgvCursos.DataSource = this.OCursos.GetAll();
        }

        public void Listar()
        {
            this.dgvCursos.DataSource = new CursoLogic().GetAll();
        }

        private void formListaCursos_Load(object sender, EventArgs e)
        {
            Listar();
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
            new CursoDesktop(ApplicationForm.ModoForm.Alta).ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvCursos.SelectedRows.Count != 0)
            {
                new CursoDesktop(((Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Modificacion).ShowDialog();
                this.Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvCursos.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Está seguro que desea eliminar este curso?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    new CursoDesktop(((Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Baja).GuardarCambios();
                    this.Listar();
                }
            }
        }
    }
}
