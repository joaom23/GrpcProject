
namespace GrpcUtilizadores.Views
{
    partial class View_Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelnomedouser = new System.Windows.Forms.Label();
            this.buttonRegistarAposta = new System.Windows.Forms.Button();
            this.buttonVerChavesAnteriores = new System.Windows.Forms.Button();
            this.buttonSuporte = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(162, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem-vindo ao Euromilhões, ";
            // 
            // labelnomedouser
            // 
            this.labelnomedouser.AutoSize = true;
            this.labelnomedouser.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelnomedouser.Location = new System.Drawing.Point(426, 40);
            this.labelnomedouser.Name = "labelnomedouser";
            this.labelnomedouser.Size = new System.Drawing.Size(72, 25);
            this.labelnomedouser.TabIndex = 1;
            this.labelnomedouser.Text = "label2";
            // 
            // buttonRegistarAposta
            // 
            this.buttonRegistarAposta.Location = new System.Drawing.Point(264, 108);
            this.buttonRegistarAposta.Name = "buttonRegistarAposta";
            this.buttonRegistarAposta.Size = new System.Drawing.Size(171, 53);
            this.buttonRegistarAposta.TabIndex = 2;
            this.buttonRegistarAposta.Text = "Registar Aposta";
            this.buttonRegistarAposta.UseVisualStyleBackColor = true;
            this.buttonRegistarAposta.Click += new System.EventHandler(this.buttonRegistarAposta_Click);
            // 
            // buttonVerChavesAnteriores
            // 
            this.buttonVerChavesAnteriores.Location = new System.Drawing.Point(264, 194);
            this.buttonVerChavesAnteriores.Name = "buttonVerChavesAnteriores";
            this.buttonVerChavesAnteriores.Size = new System.Drawing.Size(171, 53);
            this.buttonVerChavesAnteriores.TabIndex = 3;
            this.buttonVerChavesAnteriores.Text = "Chaves Apostadas Anteriormente";
            this.buttonVerChavesAnteriores.UseVisualStyleBackColor = true;
            this.buttonVerChavesAnteriores.Click += new System.EventHandler(this.buttonVerChavesAnteriores_Click);
            // 
            // buttonSuporte
            // 
            this.buttonSuporte.Location = new System.Drawing.Point(264, 277);
            this.buttonSuporte.Name = "buttonSuporte";
            this.buttonSuporte.Size = new System.Drawing.Size(171, 53);
            this.buttonSuporte.TabIndex = 4;
            this.buttonSuporte.Text = "Suporte";
            this.buttonSuporte.UseVisualStyleBackColor = true;
            this.buttonSuporte.Click += new System.EventHandler(this.buttonSuporte_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(264, 361);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(171, 53);
            this.buttonSair.TabIndex = 5;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(648, 402);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(140, 36);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // View_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonSuporte);
            this.Controls.Add(this.buttonVerChavesAnteriores);
            this.Controls.Add(this.buttonRegistarAposta);
            this.Controls.Add(this.labelnomedouser);
            this.Controls.Add(this.label1);
            this.Name = "View_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Menu";
            this.Load += new System.EventHandler(this.View_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelnomedouser;
        private System.Windows.Forms.Button buttonRegistarAposta;
        private System.Windows.Forms.Button buttonVerChavesAnteriores;
        private System.Windows.Forms.Button buttonSuporte;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonLogout;
    }
}