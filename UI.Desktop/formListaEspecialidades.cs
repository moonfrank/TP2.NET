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
    public partial class formListaEspecialidades : Form
    {
        public Especialidades OEspecialidad { get; set; }

        public formListaEspecialidades()
        {
            InitializeComponent();
            this.OEspecialidad = new Especialidades();
            this.dgvEspecialidades.DataSource = this.OEspecialidad.GetAll();
        }
        private void Especialidades_Load(object sender, EventArgs e)
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
            new EspecialidadesDesktop().ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
           
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
           
        }
        public void Listar()
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet.especialidades' Puede moverla o quitarla según sea necesario.
            //this.especialidadesTableAdapter.Fill(this.tp2_netDataSet.especialidades);
            this.dgvEspecialidades.DataSource = new EspecialidadLogic().GetAll();
        }        
    }
}
