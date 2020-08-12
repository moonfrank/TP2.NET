using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class formListaPersona : ApplicationForm
    {
        public formListaPersona()
        {
            InitializeComponent();
            this.dgvPersona.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            this.dgvPersona.DataSource = new PersonaLogic().GetAll();
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
            new PersonaDesktop(ApplicationForm.ModoForm.Alta).ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvPersona.SelectedRows.Count!=0)
            {
                new PersonaDesktop(((Persona)this.dgvPersona.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Modificacion).ShowDialog();
                this.Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvPersona.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Está seguro que desea eliminar a esta persona?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    new PersonaDesktop(((Persona)this.dgvPersona.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Baja).GuardarCambios();
                    this.Listar();
                }
            }
        }
        private void formListaPersona_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void dgvPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
