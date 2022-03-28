using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrpcUtilizadores.Views
{
    public partial class View_TermoseCondicoes : Form
    {
        public View_TermoseCondicoes()
        {
            InitializeComponent();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            checkBoxTermosCondicoes.Checked = false;
            Program.V_Home.Show();
        }

        private void buttonAceitar_Click(object sender, EventArgs e)
        {
            if (checkBoxTermosCondicoes.Checked == true)
            {
                this.Hide();
                checkBoxTermosCondicoes.Checked = false;
                //Program.V_TermoseCondicoes = new View_TermoseCondicoes();
                Program.V_Entrar.Show();
            }
            else
            {
                MessageBox.Show("Tem de confirmar assim que leu os termos e condicoes, so depois pode aceitar.", "Tem de ler e aceitar os termos",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
