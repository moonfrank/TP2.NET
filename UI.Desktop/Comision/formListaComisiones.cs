using System;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class formListaComisiones : ApplicationForm
    {
        public formListaComisiones()
        {
            InitializeComponent();
            this.dgvComisiones.AutoGenerateColumns = false;
            if (session.tipoPersona != Persona.TiposPersonas.Admin)
            {
                tsbEliminar.Enabled = false;
                tsbNuevo.Enabled = false;
                tsbEditar.Enabled = false;
            }
        }


        private void formListaComisiones_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            this.dgvComisiones.DataSource = new ComisionLogic().GetAll();
        }

        private void Comisiones_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            new ComisionDesktop(ApplicationForm.ModoForm.Alta).ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            new ComisionDesktop(((Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Modificacion).ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvComisiones.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Está seguro que desea eliminar este plan?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    new ComisionDesktop(((Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Baja).GuardarCambios();
                    this.Listar();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
