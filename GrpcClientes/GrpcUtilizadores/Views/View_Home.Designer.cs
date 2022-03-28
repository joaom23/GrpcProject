
namespace GrpcUtilizadores
{
    partial class View_Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.buttonRegras = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Location = new System.Drawing.Point(329, 52);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(140, 62);
            this.buttonEntrar.TabIndex = 0;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // buttonRegras
            // 
            this.buttonRegras.Location = new System.Drawing.Point(329, 189);
            this.buttonRegras.Name = "buttonRegras";
            this.buttonRegras.Size = new System.Drawing.Size(140, 62);
            this.buttonRegras.TabIndex = 1;
            this.buttonRegras.Text = "Regras";
            this.buttonRegras.UseVisualStyleBackColor = true;
            this.buttonRegras.Click += new System.EventHandler(this.buttonRegras_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(329, 323);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(140, 62);
            this.buttonSair.TabIndex = 2;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // View_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonRegras);
            this.Controls.Add(this.buttonEntrar);
            this.Name = "View_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.View_Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Button buttonRegras;
        private System.Windows.Forms.Button buttonSair;
    }
}

