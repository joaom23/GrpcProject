using Grpc.Core;
using Grpc.Net.Client;

using GrpcClient;
using GrpcGestao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using static GrpcClient.Gestor;

namespace GrpcUtilizadores.Views
{
    public partial class View_Vencedores : Form
    {
        //public event Vazio PedirChavesAnteriores;
        public string Username;
        public string[] numerosVencedores = new string [5];
        public string[] estrelasVencedoras = new string[2];
        public View_Vencedores()
        {
            InitializeComponent();
            Program.M_Gestao.RespostaRegistarChaves += M_Gestao_RespostaRegistarChaves;
            //Program.M_Administradores.ReceberChavesAtivas += M_Administradores_ShowChavesAtivas;
        }

        private void M_Gestao_RespostaRegistarChaves(List<RespostaVencedores> vencedores, int numero)
        {
            labelN1.Text = numerosVencedores[0];
            labelN2.Text = numerosVencedores[1];
            labelN3.Text = numerosVencedores[2];
            labelN4.Text = numerosVencedores[3];
            labelN5.Text = numerosVencedores[4];
            labelE1.Text = estrelasVencedoras[0];
            labelE2.Text = estrelasVencedoras[1];

            foreach (var item in vencedores)
            {
                if(item.Premio == 1)
                {
                    dataGridPremio1.Rows.Add(item.Nome, item.Numero1, item.Numero2, item.Numero3, item.Numero4, item.Numero5, item.Estrela1, item.Estrela2, item.DataAposta);
                     
                }
                else if(item.Premio == 2)
                {
                    dataGridPremio2.Rows.Add(item.Nome, item.Numero1, item.Numero2, item.Numero3, item.Numero4, item.Numero5, item.Estrela1, item.Estrela2, item.DataAposta);
                    
                }
                else if (item.Premio == 3)
                {
                    dataGridPremio3.Rows.Add(item.Nome, item.Numero1, item.Numero2, item.Numero3, item.Numero4, item.Numero5, item.Estrela1, item.Estrela2, item.DataAposta);

                }

                labelTotalPremio1.Text = dataGridPremio1.Rows.Count.ToString();
                labelTotalPremio2.Text = dataGridPremio2.Rows.Count.ToString();
                labelTotalPremio3.Text = dataGridPremio2.Rows.Count.ToString();

            }
        }

        //private void M_Administradores_ShowChavesAtivas(List<RespostaVisualizarApostas> apostas, int numero)
        //{
        //    foreach (var item in apostas)
        //    {
        //        //dataGridViewChavesAnteriores.DataSource = apostas;
        //        dataGridViewChavesAnteriores.Rows.Add(item.Nome ,item.Numero1, item.Numero2, item.Numero3, item.Numero4, item.Numero5, item.Estrela1, item.Estrela2, item.DataAposta);
        //    }

        //    labelTotalVencedores.Text = numero.ToString();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataGridPremio1.Rows.Clear();
            labelTotalPremio1.Text = "0";
            labelTotalPremio2.Text = "0";
            labelTotalPremio3.Text = "0";
            Program.V_Menu.Show();
        }

        private void View_Vencedores_Load(object sender, EventArgs e)
        {

        }

        //private void View_ChavesAnteriores_Load(object sender, EventArgs e)
        //{

        //    if (PedirChavesAnteriores != null)
        //    {
        //        PedirChavesAnteriores();
        //    }

        //}

    }
}
