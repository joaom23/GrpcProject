using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrpcUtilizadores.Views
{
    public partial class View_RegistarAposta : Form
    {
        //string[] matriz_numeros, matriz_estrelas;

        public event StringSeisInt RegistarAposta;
        public string Username;
        public View_RegistarAposta()
        {
            InitializeComponent();
            Program.M_Utilizadores.RespostaRegistarAposta += M_Utilizadores_RespostaRegistarAposta;
            //Username = username;
            
        }

        private void M_Utilizadores_RespostaRegistarAposta(string s)
        {
            MessageBox.Show(s, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Hide();          
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Program.V_RegistarAposta = new View_RegistarAposta();
            Program.V_Menu.Nomedouser = Username;
            Program.V_Menu.Show();
        }

        private void buttonRegistarChave_Click(object sender, EventArgs e)
        {
            if (comboBoxEstrela1.Text == "" || Convert.ToInt32(comboBoxEstrela1.Text) > 12 || comboBoxEstrela2.Text == "" || Convert.ToInt32(comboBoxEstrela2.Text) > 12
                || comboBoxNumero1.Text == "" || Convert.ToInt32(comboBoxNumero1.Text) > 50 || comboBoxNumero2.Text == "" || Convert.ToInt32(comboBoxNumero2.Text) > 50
                || comboBoxNumero3.Text == "" || Convert.ToInt32(comboBoxNumero3.Text) > 50 || comboBoxNumero4.Text == "" || Convert.ToInt32(comboBoxNumero4.Text) > 50
                || comboBoxNumero5.Text == "" || Convert.ToInt32(comboBoxNumero5.Text) > 50 || Convert.ToInt32(comboBoxEstrela1.Text) == Convert.ToInt32(comboBoxEstrela2.Text)
                || Convert.ToInt32(comboBoxNumero1.Text) == Convert.ToInt32(comboBoxNumero2.Text) || Convert.ToInt32(comboBoxNumero1.Text) == Convert.ToInt32(comboBoxNumero3.Text)
                || Convert.ToInt32(comboBoxNumero1.Text) == Convert.ToInt32(comboBoxNumero4.Text) || Convert.ToInt32(comboBoxNumero1.Text) == Convert.ToInt32(comboBoxNumero5.Text)
                || Convert.ToInt32(comboBoxNumero2.Text) == Convert.ToInt32(comboBoxNumero3.Text) || Convert.ToInt32(comboBoxNumero2.Text) == Convert.ToInt32(comboBoxNumero4.Text)
                || Convert.ToInt32(comboBoxNumero2.Text) == Convert.ToInt32(comboBoxNumero5.Text) || Convert.ToInt32(comboBoxNumero3.Text) == Convert.ToInt32(comboBoxNumero4.Text)
                || Convert.ToInt32(comboBoxNumero3.Text) == Convert.ToInt32(comboBoxNumero5.Text) || Convert.ToInt32(comboBoxNumero4.Text) == Convert.ToInt32(comboBoxNumero5.Text) /*|| textBoxNomeDoUser.Text == ""*/)
            {
                MessageBox.Show("Verifique se todos os numeros e estrelas estao preenchidos, os numeros estao compreendidos entre 50 e as estrelas 12 ou se existem numeros iguais.", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RegistarAposta?.Invoke(Username, Convert.ToInt32(comboBoxNumero1.Text), Convert.ToInt32(comboBoxNumero2.Text), Convert.ToInt32(comboBoxNumero3.Text), Convert.ToInt32(comboBoxNumero4.Text), Convert.ToInt32(comboBoxNumero5.Text), Convert.ToInt32(comboBoxEstrela1.Text), Convert.ToInt32(comboBoxEstrela2.Text));

                //this.Hide();
                //Program.V_Menu.Show();
                comboBoxNumero1.Text = string.Empty;
                comboBoxNumero2.Text = string.Empty;
                comboBoxNumero3.Text = string.Empty;
                comboBoxNumero4.Text = string.Empty;
                comboBoxNumero5.Text = string.Empty;
                comboBoxEstrela1.Text = string.Empty;
                comboBoxEstrela2.Text = string.Empty;
                // textBoxNomeDoUser.Text = string.Empty;
            }


            //if (comboBoxEstrela1.Text == "" || Convert.ToInt32(comboBoxEstrela1.Text) > 12 || comboBoxEstrela2.Text == "" || Convert.ToInt32(comboBoxEstrela1.Text) > 12 || comboBoxNumero1.Text == "" || Convert.ToInt32(comboBoxNumero1.Text) > 50 || comboBoxNumero2.Text == "" || Convert.ToInt32(comboBoxNumero2.Text) > 50 || comboBoxNumero3.Text == "" || Convert.ToInt32(comboBoxNumero3.Text) > 50 || comboBoxNumero4.Text == "" || Convert.ToInt32(comboBoxNumero4.Text) > 50 || comboBoxNumero5.Text == "" || Convert.ToInt32(comboBoxNumero5.Text) > 50)
            //{
            //    MessageBox.Show("Verifique se todos os numeros e estrelas estao preenchidos, ou os numeros estao compreendidos entre 50 e as estrelas 12.", "ERRO",
            //    MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    if (Convert.ToInt32(comboBoxEstrela1.Text) == Convert.ToInt32(comboBoxEstrela2.Text))
            //    {
            //        MessageBox.Show("É possivel que existam estrelas iguais", "Estrelas iguais",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    if (Convert.ToInt32(comboBoxNumero1.Text) == Convert.ToInt32(comboBoxNumero2.Text) || Convert.ToInt32(comboBoxNumero1.Text) == Convert.ToInt32(comboBoxNumero3.Text) || Convert.ToInt32(comboBoxNumero1.Text) == Convert.ToInt32(comboBoxNumero4.Text) || Convert.ToInt32(comboBoxNumero1.Text) == Convert.ToInt32(comboBoxNumero5.Text))
            //    {
            //        MessageBox.Show("É possivel que existam numeros iguais", "Números iguais",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    if (Convert.ToInt32(comboBoxNumero2.Text) == Convert.ToInt32(comboBoxNumero3.Text) || Convert.ToInt32(comboBoxNumero2.Text) == Convert.ToInt32(comboBoxNumero4.Text) || Convert.ToInt32(comboBoxNumero2.Text) == Convert.ToInt32(comboBoxNumero5.Text))
            //    {
            //        MessageBox.Show("É possivel que existam numeros iguais", "Números iguais",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    if (Convert.ToInt32(comboBoxNumero3.Text) == Convert.ToInt32(comboBoxNumero4.Text) || Convert.ToInt32(comboBoxNumero3.Text) == Convert.ToInt32(comboBoxNumero5.Text))
            //    {
            //        MessageBox.Show("É possivel que existam numeros iguais", "Números iguais",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    if (Convert.ToInt32(comboBoxNumero4.Text) == Convert.ToInt32(comboBoxNumero5.Text))
            //    {
            //        MessageBox.Show("É possivel que existam numeros iguais!! " + "Numero 4: " + Convert.ToInt32(comboBoxNumero4.Text) + " e Numero 5: " + Convert.ToInt32(comboBoxNumero5.Text), "Números iguais",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //    if (RegistarAposta != null)
            //    {
            //        RegistarAposta(Username, Convert.ToInt32(comboBoxNumero1.Text), Convert.ToInt32(comboBoxNumero2.Text), Convert.ToInt32(comboBoxNumero3.Text), Convert.ToInt32(comboBoxNumero4.Text), Convert.ToInt32(comboBoxNumero5.Text), Convert.ToInt32(comboBoxEstrela1.Text), Convert.ToInt32(comboBoxEstrela2.Text));
            //    }

            //matriz_numeros[0] = comboBoxNumero1.Text;
            //matriz_numeros[1] = comboBoxNumero2.Text;
            //matriz_numeros[2] = comboBoxNumero3.Text;
            //matriz_numeros[3] = comboBoxNumero4.Text;
            //matriz_numeros[4] = comboBoxNumero5.Text;

            //matriz_estrelas[0] = comboBoxEstrela1.Text;
            //matriz_estrelas[1] = comboBoxEstrela2.Text;

            //MessageBox.Show("Numeros:" + matriz_numeros[0] + " " + matriz_numeros[1] + " " + matriz_numeros[2] + " " + matriz_numeros[3] + " " + matriz_numeros[4]);
            //MessageBox.Show("estrelas:" + matriz_estrelas[0] + " " + matriz_estrelas[1]);
        }

        private void View_RegistarAposta_Load(object sender, EventArgs e)
        {
            //labelUserName.Text = Username;
        }
    }
}
