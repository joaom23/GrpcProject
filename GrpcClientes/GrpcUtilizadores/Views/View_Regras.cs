using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrpcUtilizadores.Views
{
    public partial class View_Regras : Form
    {
        public View_Regras()
        {
            InitializeComponent();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Home.Show();
        }
    }
}
