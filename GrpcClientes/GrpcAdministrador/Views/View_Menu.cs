using GrpcClient;
using GrpcUtilizadores.Views;
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

namespace GrpcAdministrador
{
    public partial class View_Menu : Form
    {
        public event Vazio ArquivarComecarNovoSorteio;
        public event Vazio PedirChavesAnteriores;
        public string Username { get; set; }
        public static View_ChavesAtivas V_ChavesAtivas { get; set; }

        public View_Menu()
        {
            InitializeComponent();
            Program.M_Administradores.RespostaArquivarEnovoSorteio += M_Administradores_RespostaArquivarEnovoSorteio;
        }

        private void M_Administradores_RespostaArquivarEnovoSorteio(string s)
        {
            MessageBox.Show(s, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Hide();
        }

        private void buttonsair_Click(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            MessageBox.Show("Até Breve", "Desconectando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void buttonapostasativas_Click(object sender, EventArgs e)
        {
            this.Hide();
            

            if (!Program.V_ChavesAtivas.First)
            {
                Program.V_ChavesAtivas.ChamarLoad();
            }

            Program.V_ChavesAtivas.Username = Username;
            Program.V_ChavesAtivas.Show();
        }

        private void buttonarquivarapostasnovosorteio_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("De certeza que quer arquivar?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                ArquivarComecarNovoSorteio?.Invoke();
            }
            else
            {

            }      

        }

        private void View_Menu_Load(object sender, EventArgs e)
        {
            labelnomedoadmin.Text = Username;
        }
    }
}
