using System;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class formLogin : ApplicationForm
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            session = null;
            Usuario usr = new UsuarioLogic().GetOne(txtUsuario.Text, txtPass.Text);
            Persona.TiposPersonas tipoPersona = new PersonaLogic().GetOne(usr.IDPersona).TipoPersona;
            if (usr.Nombre != null)
            {
                session = new Session(usr.ID, usr.IDPersona, tipoPersona);
                MessageBox.Show("Bienvienido " + usr.Nombre + ' ' + usr.Apellido + '!',
                                "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos.",
                                "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
