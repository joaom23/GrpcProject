
namespace GrpcUtilizadores.Views
{
    partial class View_TermoseCondicoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_TermoseCondicoes));
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.textBoxTermosCondicoes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxTermosCondicoes = new System.Windows.Forms.CheckBox();
            this.buttonAceitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(12, 402);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(124, 36);
            this.buttonVoltar.TabIndex = 0;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // textBoxTermosCondicoes
            // 
            this.textBoxTermosCondicoes.Location = new System.Drawing.Point(12, 72);
            this.textBoxTermosCondicoes.Multiline = true;
            this.textBoxTermosCondicoes.Name = "textBoxTermosCondicoes";
            this.textBoxTermosCondicoes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTermosCondicoes.Size = new System.Drawing.Size(776, 314);
            this.textBoxTermosCondicoes.TabIndex = 4;
            this.textBoxTermosCondicoes.Text = resources.GetString("textBoxTermosCondicoes.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "TERMOS E CONDICÕES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBoxTermosCondicoes
            // 
            this.checkBoxTermosCondicoes.AutoSize = true;
            this.checkBoxTermosCondicoes.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxTermosCondicoes.Location = new System.Drawing.Point(383, 409);
            this.checkBoxTermosCondicoes.Name = "checkBoxTermosCondicoes";
            this.checkBoxTermosCondicoes.Size = new System.Drawing.Size(263, 24);
            this.checkBoxTermosCondicoes.TabIndex = 6;
            this.checkBoxTermosCondicoes.Text = "Li e Aceitos os Termos e Condicoes";
            this.checkBoxTermosCondicoes.UseVisualStyleBackColor = false;
            // 
            // buttonAceitar
            // 
            this.buttonAceitar.BackColor = System.Drawing.Color.Transparent;
            this.buttonAceitar.Location = new System.Drawing.Point(654, 402);
            this.buttonAceitar.Name = "buttonAceitar";
            this.buttonAceitar.Size = new System.Drawing.Size(134, 36);
            this.buttonAceitar.TabIndex = 7;
            this.buttonAceitar.Text = "Aceitar";
            this.buttonAceitar.UseVisualStyleBackColor = false;
            this.buttonAceitar.Click += new System.EventHandler(this.buttonAceitar_Click);
            // 
            // View_TermoseCondicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAceitar);
            this.Controls.Add(this.checkBoxTermosCondicoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTermosCondicoes);
            this.Controls.Add(this.buttonVoltar);
            this.Name = "View_TermoseCondicoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_TermoseCondicoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.TextBox textBoxTermosCondicoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxTermosCondicoes;
        private System.Windows.Forms.Button buttonAceitar;
    }
}