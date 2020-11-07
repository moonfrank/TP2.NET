using System;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class formListaDocenteCurso : ApplicationForm
    {
        public formListaDocenteCurso()
        {
            InitializeComponent();
            this.dgvDocenteCurso.AutoGenerateColumns = false;
            if (session.tipoPersona != Persona.TiposPersonas.Admin)
            {
                tsbEliminar.Enabled = false;
                tsbNuevo.Enabled = false;
                tsbEditar.Enabled = false;
            }
        }

        public void Listar()
        {
            this.dgvDocenteCurso.DataSource = new DocenteCursoLogic().GetAll();
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
            new DocenteCursoDesktop(ApplicationForm.ModoForm.Alta).ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvDocenteCurso.SelectedRows.Count!=0)
            {
                new DocenteCursoDesktop(((DocenteCurso)this.dgvDocenteCurso.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Modificacion).ShowDialog();
                this.Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvDocenteCurso.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Está seguro que desea eliminar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    new DocenteCursoDesktop(((DocenteCurso)this.dgvDocenteCurso.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Baja).GuardarCambios();
                    this.Listar();
                }
            }
        }

        private void DocenteCurso_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
