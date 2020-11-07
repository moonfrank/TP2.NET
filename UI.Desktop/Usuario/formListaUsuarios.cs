using System;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;
using System.Linq;

namespace UI.Desktop
{
    public partial class formListaUsuarios : ApplicationForm
    {
        public formListaUsuarios()
        {
            InitializeComponent();
            this.dgvUsuarios.AutoGenerateColumns = false;
            this.Listar();
            if (session.tipoPersona != Persona.TiposPersonas.Admin)
            {
                this.tsbNuevo.Enabled = false;
                this.tsbEliminar.Enabled = false;
            }
        }

        public void Listar()
        {
           var usuarios = new UsuarioLogic().GetAll();
            if (session.tipoPersona != Persona.TiposPersonas.Admin)
            {
                this.dgvUsuarios.DataSource = (from a in usuarios
                                               where a.ID == session.userID
                                               select a
                                              ).ToList();
            }
            else
                this.dgvUsuarios.DataSource = usuarios;
        }

        private void Usuarios_Load(object sender, EventArgs e)
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
            new UsuarioDesktop(ApplicationForm.ModoForm.Alta).ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.SelectedRows.Count!=0)
            {
                new UsuarioDesktop(((Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Modificacion).ShowDialog();
                this.Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Está seguro que desea eliminar a este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    new UsuarioDesktop(((Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Baja).GuardarCambios();
                    this.Listar();
                }
            }
        }
    }
}
