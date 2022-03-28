
namespace GrpcUtilizadores.Views
{
    partial class View_Suporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Suporte));
            this.textBoxDestinatário = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxEmailPess = new System.Windows.Forms.TextBox();
            this.textBoxTextoEmail = new System.Windows.Forms.TextBox();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDestinatário
            // 
            this.textBoxDestinatário.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxDestinatário.Location = new System.Drawing.Point(163, 185);
            this.textBoxDestinatário.Multiline = true;
            this.textBoxDestinatário.Name = "textBoxDestinatário";
            this.textBoxDestinatário.ReadOnly = true;
            this.textBoxDestinatário.Size = new System.Drawing.Size(383, 42);
            this.textBoxDestinatário.TabIndex = 0;
            this.textBoxDestinatário.Text = "al66518@utad.eu";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(163, 233);
            this.textBoxTitulo.Multiline = true;
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(383, 42);
            this.textBoxTitulo.TabIndex = 1;
            // 
            // textBoxEmailPess
            // 
            this.textBoxEmailPess.Location = new System.Drawing.Point(163, 279);
            this.textBoxEmailPess.Multiline = true;
            this.textBoxEmailPess.Name = "textBoxEmailPess";
            this.textBoxEmailPess.Size = new System.Drawing.Size(383, 42);
            this.textBoxEmailPess.TabIndex = 2;
            this.textBoxEmailPess.Text = "\r\n";
            // 
            // textBoxTextoEmail
            // 
            this.textBoxTextoEmail.Location = new System.Drawing.Point(163, 327);
            this.textBoxTextoEmail.Multiline = true;
            this.textBoxTextoEmail.Name = "textBoxTextoEmail";
            this.textBoxTextoEmail.Size = new System.Drawing.Size(383, 123);
            this.textBoxTextoEmail.TabIndex = 3;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(365, 463);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(181, 53);
            this.buttonEnviar.TabIndex = 4;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(163, 463);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(181, 53);
            this.buttonVoltar.TabIndex = 5;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(25, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Titulo / Problema: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(63, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "O seu Email: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(105, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Texto: ";
            // 
            // View_Suporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(707, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.textBoxTextoEmail);
            this.Controls.Add(this.textBoxEmailPess);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.textBoxDestinatário);
            this.Name = "View_Suporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Suporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDestinatário;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxEmailPess;
        private System.Windows.Forms.TextBox textBoxTextoEmail;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}