using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrpcUtilizadores
{
    public partial class View_Home : Form
    {
        public View_Home()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Thread.Sleep(600);
            MessageBox.Show("Obrigado por usar a aplicação!", "Desconectando...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void buttonRegras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Regras.Show();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para Entrar, tem de aceitar os termos e condicoes", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            Program.V_TermoseCondicoes.Show();
        }

        private void View_Home_Load(object sender, EventArgs e)
        {

        }
    }
}
