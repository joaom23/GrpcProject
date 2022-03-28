using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GrpcAdministrador.Views
{
    public partial class View_Entrar : Form
    {
        public event UmaString EntradaAdmnistrador;

        public View_Entrar()
        {
            InitializeComponent();
            Program.M_Administradores.RespostaEntrarAdmnistrador += M_Administradores_RespostaEntrarAdmnistrador;
        }

        private void M_Administradores_RespostaEntrarAdmnistrador(string s)
        {
            MessageBox.Show(s, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Thread.Sleep(600);
            MessageBox.Show("Ate breve", "Desconectando...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
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
                if (EntradaAdmnistrador != null)
                {
                    EntradaAdmnistrador(Convert.ToString(textBoxnomeuser.Text));
                    this.Hide();
                    Program.V_Menu.Username = textBoxnomeuser.Text;
                    Program.V_Menu.Show();
                }
                
            }
        }

        private void View_Entrar_Load(object sender, EventArgs e)
        {

        }
    }
}
