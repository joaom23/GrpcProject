using GrpcClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrpcGestao.Views
{
    public partial class View_RegistarChaveVencedora : Form
    {
        public event SeteInt RegistarChavesVencedora;

        public View_RegistarChaveVencedora()
        {
            InitializeComponent();
            Program.M_Gestao.RespostaRegistarChaves += M_Gestao_RespostaRegistarChaves;
        }

        private void M_Gestao_RespostaRegistarChaves(List<RespostaVencedores> vencedores,int numero)
        {
            //foreach (var item in vencedores)
            //{
            //    //dataGridViewChavesAnteriores.DataSource = apostas;
            //    dataGridViewChavesAnteriores.Rows.Add(item.Nome,item.Numero1, item.Numero2, item.Numero3, item.Numero4, item.Numero5, item.Estrela1, item.Estrela2, item.DataAposta);
            //    labelTotalVencedores.Text = numero.ToString();
            //}
            //this.Hide();
            //Program.V_RegistarChaveVencedora.Show();
        }

        // public string Nomegestor { get; set; }


        private void buttonRegistarChaveVencedora_Click(object sender, EventArgs e)
        {
            if (comboBoxEstrela1.Text == "" || Convert.ToInt32(comboBoxEstrela1.Text) > 12 || comboBoxEstrela2.Text == "" || Convert.ToInt32(comboBoxEstrela2.Text) > 12
                || comboBoxxNumero1.Text == "" || Convert.ToInt32(comboBoxxNumero1.Text) > 50 || comboBoxNumero2.Text == "" || Convert.ToInt32(comboBoxNumero2.Text) > 50
                || comboBoxNumero3.Text == "" || Convert.ToInt32(comboBoxNumero3.Text) > 50 || comboBoxNumero4.Text == "" || Convert.ToInt32(comboBoxNumero4.Text) > 50
                || comboBoxNumero5.Text == "" || Convert.ToInt32(comboBoxNumero5.Text) > 50 || Convert.ToInt32(comboBoxEstrela1.Text) == Convert.ToInt32(comboBoxEstrela2.Text)
                || Convert.ToInt32(comboBoxxNumero1.Text) == Convert.ToInt32(comboBoxNumero2.Text) || Convert.ToInt32(comboBoxxNumero1.Text) == Convert.ToInt32(comboBoxNumero3.Text)
                || Convert.ToInt32(comboBoxxNumero1.Text) == Convert.ToInt32(comboBoxNumero4.Text) || Convert.ToInt32(comboBoxxNumero1.Text) == Convert.ToInt32(comboBoxNumero5.Text)
                || Convert.ToInt32(comboBoxNumero2.Text) == Convert.ToInt32(comboBoxNumero3.Text) || Convert.ToInt32(comboBoxNumero2.Text) == Convert.ToInt32(comboBoxNumero4.Text)
                || Convert.ToInt32(comboBoxNumero2.Text) == Convert.ToInt32(comboBoxNumero5.Text) || Convert.ToInt32(comboBoxNumero3.Text) == Convert.ToInt32(comboBoxNumero4.Text)
                || Convert.ToInt32(comboBoxNumero3.Text) == Convert.ToInt32(comboBoxNumero5.Text) || Convert.ToInt32(comboBoxNumero4.Text) == Convert.ToInt32(comboBoxNumero5.Text) /*|| textBoxNomeDoUser.Text == ""*/)
            {
                MessageBox.Show("Verifique se todos os numeros e estrelas estao preenchidos, os numeros estao compreendidos entre 50 e as estrelas 12 ou se existem numeros iguais.", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (RegistarChavesVencedora != null)
                {
                    RegistarChavesVencedora( Convert.ToInt32(comboBoxxNumero1.Text), Convert.ToInt32(comboBoxNumero2.Text), Convert.ToInt32(comboBoxNumero3.Text), Convert.ToInt32(comboBoxNumero4.Text), Convert.ToInt32(comboBoxNumero5.Text), Convert.ToInt32(comboBoxEstrela1.Text), Convert.ToInt32(comboBoxEstrela2.Text));
                    this.Hide();

                    Program.V_Vencedores.numerosVencedores[0] = comboBoxxNumero1.Text;
                    Program.V_Vencedores.numerosVencedores[1] = comboBoxNumero2.Text;
                    Program.V_Vencedores.numerosVencedores[2] = comboBoxNumero3.Text;
                    Program.V_Vencedores.numerosVencedores[3] = comboBoxNumero4.Text;
                    Program.V_Vencedores.numerosVencedores[4] = comboBoxNumero5.Text;

                    Program.V_Vencedores.estrelasVencedoras[0] = comboBoxEstrela1.Text;
                    Program.V_Vencedores.estrelasVencedoras[1] = comboBoxEstrela2.Text;

                    Program.V_Vencedores.Show();
                   
                }

                //this.Hide();
                //Program.V_Menu.Show();
                comboBoxxNumero1.Text = string.Empty;
                comboBoxNumero2.Text = string.Empty;
                comboBoxNumero3.Text = string.Empty;
                comboBoxNumero4.Text = string.Empty;
                comboBoxNumero5.Text = string.Empty;
                comboBoxEstrela1.Text = string.Empty;
                comboBoxEstrela2.Text = string.Empty;
                // textBoxNomeDoUser.Text = string.Empty;
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_RegistarChaveVencedora = new View_RegistarChaveVencedora();
            Program.V_Menu.Show();
            //View_Menu destino_nome = new View_Menu();
            //destino_nome.Nomedogestor = labelnomedouserdogestor.Text;
            //destino_nome.Show();

        }

        private void View_RegistarChaveVencedora_Load(object sender, EventArgs e)
        {
            //labelnomedouserdogestor.Text = this.Nomegestor;
        }
    }
}
