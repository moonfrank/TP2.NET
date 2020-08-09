using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class formListaComisiones : ApplicationForm
    {
        public Comisiones OComisiones { get; set; }
        public formListaComisiones()
        {
            InitializeComponent();
            this.dgvComisiones.AutoGenerateColumns = false;
            this.OComisiones = new Comisiones();
            this.dgvComisiones.DataSource = this.OComisiones.GetAll();
        }


        private void formListaComisiones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'academiaDataSet.comisiones' table. You can move, or remove it, as needed.
            this.comisionesTableAdapter.Fill(this.academiaDataSet.comisiones);

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
