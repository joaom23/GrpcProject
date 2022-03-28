using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace GrpcUtilizadores.Views
{
    public partial class View_Suporte : Form
    {
        private MailMessage Email;
        Stopwatch Stop = new Stopwatch();

        public View_Suporte()
        {
            InitializeComponent();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            while (textBoxEmailPess.Text == "")
            {
                MessageBox.Show("Insira o seu Email");
            }

            if (textBoxTextoEmail.ToString() != "")
            {
                Email = new MailMessage();
                Email.To.Add(new MailAddress(textBoxDestinatário.Text));
                Email.From = (new MailAddress(textBoxDestinatário.Text));
                Email.Subject = textBoxTitulo.Text;
                Email.IsBodyHtml = true;
                Email.Body = textBoxEmailPess.Text + "\n \n" + textBoxTextoEmail.Text;
                SmtpClient cliente = new SmtpClient("smtp.live.com", 587);
                using (cliente)
                {
                    cliente.Credentials = new System.Net.NetworkCredential(textBoxDestinatário.Text, "88vv22un");
                    cliente.EnableSsl = true;
                    cliente.Send(Email);
                }
                textBoxTextoEmail.Clear();
                textBoxTitulo.Clear();
                MessageBox.Show("Email enviado com sucesso", "Suporte",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Email nao enviado, tente novamente","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
            Program.V_Menu.Show();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Suporte = new View_Suporte();
            Program.V_Menu.Show();
        }
    }
}
