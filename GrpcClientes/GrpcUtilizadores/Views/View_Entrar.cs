using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrpcUtilizadores.Views
{
    public partial class View_Entrar : Form
    {
        public event StringInt EntrarUtilizador;

        public View_Entrar()
        {
            InitializeComponent();
            Program.M_Utilizadores.RespostaEntrarUtilizador += M_Utilizadores_RespostaEntrarUtilizador;
            
            //View_Menu destino_nome = new View_Menu();
            //destino_nome.Nomedouser = textBoxnomeuser.Text;
            //destino_nome.Show();
        }

        private void M_Utilizadores_RespostaEntrarUtilizador(string s)
        {
            MessageBox.Show(s, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            //View_Menu destino_nome = new View_Menu();
            //destino_nome.Nomedouser = textBoxnomeuser.Text;
            //destino_nome.Show();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Home.Show();
            textBoxnomeuser.Text = string.Empty;
            textBoxIdade.Text = string.Empty;
        }

        private void buttonentrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIdade.Text) /*|| string.IsNullOrWhiteSpace(textBoxIdade.Text)*/)
            {
                MessageBox.Show("Tem de inserir uma idade", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxIdade.Text = string.Empty;
                //textBoxnomeuser.Text = string.Empty;

            }
            else if(Convert.ToInt32(textBoxIdade.Text) < 18)
            {
                MessageBox.Show("Para entrar, tem de ter +18 anos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxIdade.Text = string.Empty;
            }
            else if(string.IsNullOrWhiteSpace(textBoxnomeuser.Text))
            {
                MessageBox.Show("Para entrar tem de colocar o seu nome de utilizador", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxIdade.Text = string.Empty;
                textBoxnomeuser.Text = string.Empty;
            }
            else {

                //this.Hide();
                if (EntrarUtilizador != null)
                {
                    EntrarUtilizador(textBoxnomeuser.Text, Convert.ToInt32(textBoxIdade.Text));
                    View_Menu destino_nome = new View_Menu();
                    destino_nome.Nomedouser = textBoxnomeuser.Text;
                    destino_nome.Show();
                    this.Hide();
                }
                //View_Menu destino_nome = new View_Menu();
                //destino_nome.Nomedouser = textBoxnomeuser.Text;
                //destino_nome.Show();
                

            }

        }

        private void View_Entrar_Load(object sender, EventArgs e)
        {

        }
    }
}
