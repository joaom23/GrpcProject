using GrpcGestao.Views;
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

namespace GrpcGestao
{
    public partial class View_Home : Form
    {
        public event UmaString EntradaGestor;

        public View_Home()
        {
            InitializeComponent();
            Program.M_Gestao.RespostaEntrarGestor += M_Gestao_RespostaEntrarGestor;
        }

        private void M_Gestao_RespostaEntrarGestor(string s)
        {
            MessageBox.Show(s, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void buttonentrar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(textBoxnomeuser.Text))
            {
                MessageBox.Show("Para entrar tem de colocar o seu nome de gestor", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxnomeuser.Text = string.Empty;
            }
            else
            {
                EntradaGestor?.Invoke(Convert.ToString(textBoxnomeuser.Text));
            }

            this.Hide();
            Program.V_Menu.Nomedogestor = textBoxnomeuser.Text;
            Program.V_Menu.Show();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Thread.Sleep(600);
            MessageBox.Show("Ate breve", "Desconectando...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void View_Home_Load(object sender, EventArgs e)
        {

        }
    }
}
