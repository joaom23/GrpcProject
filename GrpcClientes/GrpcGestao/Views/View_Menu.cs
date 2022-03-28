using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GrpcGestao.Views
{
    public partial class View_Menu : Form
    {
        public View_Menu()
        {
            InitializeComponent();
            
        }

        public string Nomedogestor { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(600);
            MessageBox.Show("Obrigado por usar a aplicação!", "Desconectando...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void View_Menu_Load(object sender, EventArgs e)
        {
            labelnomedogestor.Text = this.Nomedogestor;
        }

        private void buttonRegistarChave_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_RegistarChaveVencedora.Show();
        }
    }
}
