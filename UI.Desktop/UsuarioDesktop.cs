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
using System.Text.RegularExpressions;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        public UsuarioDesktop()
        {
            InitializeComponent();
        }

        public UsuarioDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public UsuarioDesktop(int ID, ModoForm modo) : this(modo)
        {
            this.UsuarioActual = new UsuarioLogic().GetOne(ID);
            MapearDeDatos();
        }
        public Usuario UsuarioActual { get; set; }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtEmail.Text = this.UsuarioActual.Email;
            switch(this.Modo)
            {
                case ModoForm.Alta:
                case ModoForm.Modificacion:
                    {
                        btnAceptar.Text = "Guardar";
                        break;
                    }
                case ModoForm.Baja:
                    {
                        btnAceptar.Text = "Eliminar";
                        break;
                    }
                default:
                    {
                        btnAceptar.Text = "Aceptar";
                        break;
                    }
            }
        }
        public override void MapearADatos()
        {
            if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion)
            {
                if(this.Modo == ModoForm.Alta) this.UsuarioActual = new Usuario();
                else this.UsuarioActual.ID = int.Parse(this.txtID.Text);

                this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                this.UsuarioActual.Nombre = this.txtNombre.Text;
                this.UsuarioActual.Apellido = this.txtApellido.Text;
                this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                this.UsuarioActual.Clave = this.txtClave.Text;
                this.UsuarioActual.Email = this.txtEmail.Text;

                switch(Modo)
                {
                    case ModoForm.Alta:
                        {
                            UsuarioActual.State = BusinessEntity.States.New;
                            break;
                        }
                    case ModoForm.Baja:
                        {
                            UsuarioActual.State = BusinessEntity.States.Deleted;
                            break;
                        }
                    case ModoForm.Consulta:
                        {
                            UsuarioActual.State = BusinessEntity.States.Unmodified;
                            break;
                        }
                    case ModoForm.Modificacion:
                        {
                            UsuarioActual.State = BusinessEntity.States.Modified;
                            break;
                        }
                }
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            switch(this.Modo)
            {
                case ModoForm.Alta:
                case ModoForm.Modificacion:
                    {
                        new UsuarioLogic().Save(UsuarioActual);
                        break;
                    }
                case ModoForm.Baja:
                    {
                        new UsuarioLogic().Delete(UsuarioActual.ID);
                        break;
                    }
                default: break;
            }
        }
        public override bool Validar()
        {
            String expresion = "\\w+([-+.']\\w+)@\\w+([-.]\\w+)\\.\\w+([-.]\\w+)*";
            if (this.txtClave.Text.Equals(this.txtConfirm.Text) && txtClave.Text.Length >= 8 &&
                Regex.IsMatch(this.txtEmail.Text, expresion) && Regex.Replace(this.txtEmail.Text, expresion, String.Empty).Length == 0 &&
                !String.IsNullOrEmpty(this.txtNombre.Text) && !String.IsNullOrEmpty(this.txtApellido.Text) && !String.IsNullOrEmpty(this.txtUsuario.Text)) return true;
            else
            {
                Notificar("Error", "Ingreso de datos inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
