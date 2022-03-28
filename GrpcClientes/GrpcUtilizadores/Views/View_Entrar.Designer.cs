
namespace GrpcUtilizadores.Views
{
    partial class View_Entrar
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
            this.textBoxnomeuser = new System.Windows.Forms.TextBox();
            this.buttonentrar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxnomeuser
            // 
            this.textBoxnomeuser.Location = new System.Drawing.Point(222, 89);
            this.textBoxnomeuser.Name = "textBoxnomeuser";
            this.textBoxnomeuser.Size = new System.Drawing.Size(285, 27);
            this.textBoxnomeuser.TabIndex = 0;
            // 
            // buttonentrar
            // 
            this.buttonentrar.Location = new System.Drawing.Point(387, 200);
            this.buttonentrar.Name = "buttonentrar";
            this.buttonentrar.Size = new System.Drawing.Size(120, 42);
            this.buttonentrar.TabIndex = 1;
            this.buttonentrar.Text = "Entrar";
            this.buttonentrar.UseVisualStyleBackColor = true;
            this.buttonentrar.Click += new System.EventHandler(this.buttonentrar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(222, 200);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(120, 42);
            this.buttonVoltar.TabIndex = 2;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome de utilizador : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(147, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Idade : ";
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(222, 144);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(81, 27);
            this.textBoxIdade.TabIndex = 5;
            // 
            // View_Entrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 332);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonentrar);
            this.Controls.Add(this.textBoxnomeuser);
            this.Name = "View_Entrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrar";
            this.Load += new System.EventHandler(this.View_Entrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxnomeuser;
        private System.Windows.Forms.Button buttonentrar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIdade;
    }
}