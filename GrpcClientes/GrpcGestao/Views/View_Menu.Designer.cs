
namespace GrpcGestao.Views
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
            this.buttonRegistarChave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelnomedogestor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRegistarChave
            // 
            this.buttonRegistarChave.Location = new System.Drawing.Point(280, 153);
            this.buttonRegistarChave.Name = "buttonRegistarChave";
            this.buttonRegistarChave.Size = new System.Drawing.Size(150, 54);
            this.buttonRegistarChave.TabIndex = 0;
            this.buttonRegistarChave.Text = "Registar Chave Vencedora";
            this.buttonRegistarChave.UseVisualStyleBackColor = true;
            this.buttonRegistarChave.Click += new System.EventHandler(this.buttonRegistarChave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(193, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bem-Vindo, ";
            // 
            // labelnomedogestor
            // 
            this.labelnomedogestor.AutoSize = true;
            this.labelnomedogestor.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelnomedogestor.Location = new System.Drawing.Point(371, 63);
            this.labelnomedogestor.Name = "labelnomedogestor";
            this.labelnomedogestor.Size = new System.Drawing.Size(74, 30);
            this.labelnomedogestor.TabIndex = 3;
            this.labelnomedogestor.Text = "label2";
            // 
            // View_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 383);
            this.Controls.Add(this.labelnomedogestor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonRegistarChave);
            this.Name = "View_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.View_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistarChave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelnomedogestor;
    }
}