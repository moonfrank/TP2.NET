﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class formMain : ApplicationForm
    {
        public formMain()
        {
            InitializeComponent();
        }
        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void formMain_Shown(object sender, EventArgs e)
        {
            formLogin appLogin = new formLogin();
            if (appLogin.ShowDialog() != DialogResult.OK) this.Dispose();
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            formListaUsuarios appListaUsuarios = new formListaUsuarios();
            if (appListaUsuarios.ShowDialog() != DialogResult.OK) this.Dispose();
        }
    }
}
