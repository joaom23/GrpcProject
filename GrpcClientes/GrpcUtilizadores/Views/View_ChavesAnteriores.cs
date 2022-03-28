using Grpc.Core;
using Grpc.Net.Client;
using GrpcClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using static GrpcClient.Jogador;

namespace GrpcUtilizadores.Views
{
    public partial class View_ChavesAnteriores : Form
    {
        //public event UmaString VerChavesAnteriores;
        public event UmaString ApresentarChavesAnteriores;
        public string Username;
       public bool First { get; set; } = true;

        public View_ChavesAnteriores()
        {
            InitializeComponent();
            Program.M_Utilizadores.RespostaChavesAnteriores += M_Utilizadores_RespostaChavesAnteriores1;
        }

        private void M_Utilizadores_RespostaChavesAnteriores1(List<JogadorChavesAnteriores> apostas, int numero)
        {
            foreach (var item in apostas)
            {
                //dataGridViewChavesAnteriores.DataSource = apostas;
                dataGridViewChavesAnteriores.Rows.Add(item.Numero1, item.Numero2, item.Numero3, item.Numero4, item.Numero5, item.Estrela1, item.Estrela2, item.DataAposta);
                labelTotalChavesAnteriores.Text = numero.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataGridViewChavesAnteriores.Rows.Clear();
            Program.V_Menu.Nomedouser = Username;
            Program.V_Menu.Show();

         
            // textBoxChavesAnteriores.Text = string.Empty;
        }

        private void buttonAjuda_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Suporte.Show();
           // textBoxChavesAnteriores.Text = string.Empty;
        }

        private void View_ChavesAnteriores_Load(object sender, EventArgs e)
        {
            First = false;

            ApresentarChavesAnteriores?.Invoke(Username);

        }

        private void View_ChavesAnteriores_Load_1(object sender, EventArgs e)
        {

        }

        public void ChamarLoad()
        {
            View_ChavesAnteriores_Load(new object(), new EventArgs());
        }
    }
}
