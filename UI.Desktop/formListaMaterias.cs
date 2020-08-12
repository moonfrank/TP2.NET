using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class formListaMaterias : ApplicationForm
    {
        public formListaMaterias()
        {
            InitializeComponent();
            this.dgvMaterias.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            this.dgvMaterias.DataSource = new MateriaLogic().GetAll();
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
            new MateriaDesktop(ApplicationForm.ModoForm.Alta).ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvMaterias.SelectedRows.Count != 0)
            {
                new MateriaDesktop(((Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Modificacion).ShowDialog();
                this.Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvMaterias.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Está seguro que desea eliminar esta materia?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    new MateriaDesktop(((Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Baja).GuardarCambios();
                    this.Listar();
                }
            }
        }

        private void formListaMaterias_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
