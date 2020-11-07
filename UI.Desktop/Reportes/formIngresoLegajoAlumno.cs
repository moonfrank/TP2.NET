using System;
using System.Windows.Forms;

namespace UI.Desktop.Reportes
{
    public partial class formIngresoLegajoAlumno : Form
    {
        public int alumno;
        public formIngresoLegajoAlumno()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            while (!int.TryParse(txtLegajo.Text, out alumno))
                MessageBox.Show("Formato de legajo incorrecto.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.DialogResult = DialogResult.OK;
            alumno = int.Parse(txtLegajo.Text);
        }
    }
}
