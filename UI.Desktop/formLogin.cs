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
    public partial class formLogin : ApplicationForm
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usr = new UsuarioLogic().GetOne(txtUsuario.Text, txtPass.Text);
            if (usr.Nombre!=null)
            {
                MessageBox.Show("Bienvienido "+usr.Nombre+' '+usr.Apellido+'!',
                                "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos.",
                                "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkOlvidaPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Qué macana, che...",
                               "Olvidé mi contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
