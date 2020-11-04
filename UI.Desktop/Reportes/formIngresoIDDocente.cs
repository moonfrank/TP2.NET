using Business.Logic;
using Business.Entities;
using System;
using System.Windows.Forms;
using System.Linq;

namespace UI.Desktop.Reportes
{
    public partial class formIngresoIDDocente : ApplicationForm
    {
        public int docente;
        public formIngresoIDDocente()
        {
            InitializeComponent();
        }

        public void formIngresoIDDocente_Load1(object sender, EventArgs e)
        {
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            docente = int.Parse(cboxIDDocente.Text);
        }

        private void formIngresoIDDocente_Load(object sender, EventArgs e)
        {
            var idProfesores = from a in new PersonaLogic().GetAll()
                               where a.TipoPersona.ToString() == "Profesor"
                               select a.ID;

            // cboxIDDocente.DataSource = idProfesores;
            foreach (int p in idProfesores)
            {
                cboxIDDocente.Items.Add(p.ToString());
            }
        }
    }
}
