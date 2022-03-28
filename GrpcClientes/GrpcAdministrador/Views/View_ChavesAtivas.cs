using Grpc.Core;
using Grpc.Net.Client;
using GrpcAdministrador;
using GrpcClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using static GrpcClient.Administrador;

namespace GrpcUtilizadores.Views
{
    public partial class View_ChavesAtivas : Form
    {
        public event Vazio PedirChavesAtivas;
        public string Username;
        public bool First { get; set; } = true;

        public View_ChavesAtivas()
        {
 
            InitializeComponent();
            Program.M_Administradores.ReceberChavesAtivas += M_Administradores_ShowChavesAtivas;

        }

        private void M_Administradores_ShowChavesAtivas(List<RespostaVisualizarApostas> apostas, int numero)
        {
            foreach (var item in apostas)
            {
                //dataGridViewChavesAnteriores.DataSource = apostas;
                dataGridViewChavesAnteriores.Rows.Add(item.Nome ,item.Numero1, item.Numero2, item.Numero3, item.Numero4, item.Numero5, item.Estrela1, item.Estrela2, item.DataAposta);
                //dataGridViewChavesAnteriores.Update();
            }

            labelTotalChavesAtivas.Text = numero.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataGridViewChavesAnteriores.Rows.Clear();
            Program.V_Menu.Username = Username;
            Program.V_Menu.Show();
        }

        private void View_ChavesAtivas_Load(object sender, EventArgs e)
        {
            First = false;

            PedirChavesAtivas?.Invoke();

        }

        public void ChamarLoad()
        {
            View_ChavesAtivas_Load(new object(), new EventArgs());
        }

        private void View_ChavesAtivas_Load_1(object sender, EventArgs e)
        {

        }
    }
}
