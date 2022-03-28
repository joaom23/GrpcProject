
namespace GrpcAdministrador
{
    partial class View_Menu
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
            this.buttonapostasativas = new System.Windows.Forms.Button();
            this.buttonarquivarapostasnovosorteio = new System.Windows.Forms.Button();
            this.buttonsair = new System.Windows.Forms.Button();
            this.labelnomedoadmin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonapostasativas
            // 
            this.buttonapostasativas.Location = new System.Drawing.Point(281, 102);
            this.buttonapostasativas.Name = "buttonapostasativas";
            this.buttonapostasativas.Size = new System.Drawing.Size(208, 74);
            this.buttonapostasativas.TabIndex = 0;
            this.buttonapostasativas.Text = "Ver apostas ativas";
            this.buttonapostasativas.UseVisualStyleBackColor = true;
            this.buttonapostasativas.Click += new System.EventHandler(this.buttonapostasativas_Click);
            // 
            // buttonarquivarapostasnovosorteio
            // 
            this.buttonarquivarapostasnovosorteio.Location = new System.Drawing.Point(281, 203);
            this.buttonarquivarapostasnovosorteio.Name = "buttonarquivarapostasnovosorteio";
            this.buttonarquivarapostasnovosorteio.Size = new System.Drawing.Size(208, 74);
            this.buttonarquivarapostasnovosorteio.TabIndex = 1;
            this.buttonarquivarapostasnovosorteio.Text = "Arquivar Apostas e Comecar novo sorteio";
            this.buttonarquivarapostasnovosorteio.UseVisualStyleBackColor = true;
            this.buttonarquivarapostasnovosorteio.Click += new System.EventHandler(this.buttonarquivarapostasnovosorteio_Click);
            // 
            // buttonsair
            // 
            this.buttonsair.Location = new System.Drawing.Point(281, 301);
            this.buttonsair.Name = "buttonsair";
            this.buttonsair.Size = new System.Drawing.Size(208, 74);
            this.buttonsair.TabIndex = 2;
            this.buttonsair.Text = "Sair";
            this.buttonsair.UseVisualStyleBackColor = true;
            this.buttonsair.Click += new System.EventHandler(this.buttonsair_Click);
            // 
            // labelnomedoadmin
            // 
            this.labelnomedoadmin.AutoSize = true;
            this.labelnomedoadmin.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelnomedoadmin.Location = new System.Drawing.Point(415, 42);
            this.labelnomedoadmin.Name = "labelnomedoadmin";
            this.labelnomedoadmin.Size = new System.Drawing.Size(74, 30);
            this.labelnomedoadmin.TabIndex = 5;
            this.labelnomedoadmin.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(237, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bem-Vindo, ";
            // 
            // View_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelnomedoadmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonsair);
            this.Controls.Add(this.buttonarquivarapostasnovosorteio);
            this.Controls.Add(this.buttonapostasativas);
            this.Name = "View_Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.View_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonapostasativas;
        private System.Windows.Forms.Button buttonarquivarapostasnovosorteio;
        private System.Windows.Forms.Button buttonsair;
        private System.Windows.Forms.Label labelnomedoadmin;
        private System.Windows.Forms.Label label1;
    }
}

