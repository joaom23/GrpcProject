using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GrpcUtilizadores.Views
{
    public partial class View_Menu : Form
    {
        //public event Vazio PreencherNomeUtilizador;
        //public event Vazio PedidoChaves;
        private string Username;
        public event UmaString ApresentarChavesAnteriores;

        public View_Menu()
        {
            InitializeComponent();
            //Program.M_Euromilhoes.RespostaPreencherUtilizador += M_Euromilhoes_RespostaPreencherUtilizador;
        
        }

        public string Nomedouser { get; set; }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Thread.Sleep(600);
            MessageBox.Show("Obrigado por usar a aplicação!", "Desconectando...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void buttonSuporte_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Suporte.Show();
        }

        private void buttonRegistarAposta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_RegistarAposta.Username = Nomedouser;
            Program.V_RegistarAposta.Show();
            //View_RegistarAposta registar = new View_RegistarAposta();
            //registar.Username = Nomedouser;
            //registar.Show();
        }

        private void buttonVerChavesAnteriores_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_ChavesAnteriores.Username = Nomedouser;
            

            if (!Program.V_ChavesAnteriores.First)
            {
                Program.V_ChavesAnteriores.ChamarLoad();
            }

            Program.V_ChavesAnteriores.Show();
            //View_ChavesAnteriores view = new View_ChavesAnteriores();
            //view.Username = Nomedouser;
            //view.Show();
        }

        private void View_Menu_Load(object sender, EventArgs e)
        {
           // labelnomedouser.Text = this.Nomedouser;
            labelnomedouser.Text = Nomedouser;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Thread.Sleep(600);
            MessageBox.Show("Obrigado por usar a aplicação!", "Desconectando...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Program.V_Menu = new View_Menu();
            this.Hide();
            Program.V_Home.Show();
        }

        //private void M_Euromilhoes_RespostaPreencherUtilizador()
        //{
        //    //labelnome.Text = Program.C_Euromilhoes.Nome;
        //}

    }
}
