
namespace GrpcGestao
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonentrar = new System.Windows.Forms.Button();
            this.textBoxnomeuser = new System.Windows.Forms.TextBox();
            this.buttonSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome de gestor : ";
            // 
            // buttonentrar
            // 
            this.buttonentrar.Location = new System.Drawing.Point(341, 101);
            this.buttonentrar.Name = "buttonentrar";
            this.buttonentrar.Size = new System.Drawing.Size(128, 42);
            this.buttonentrar.TabIndex = 7;
            this.buttonentrar.Text = "Entrar";
            this.buttonentrar.UseVisualStyleBackColor = true;
            this.buttonentrar.Click += new System.EventHandler(this.buttonentrar_Click);
            // 
            // textBoxnomeuser
            // 
            this.textBoxnomeuser.Location = new System.Drawing.Point(184, 59);
            this.textBoxnomeuser.Name = "textBoxnomeuser";
            this.textBoxnomeuser.Size = new System.Drawing.Size(285, 27);
            this.textBoxnomeuser.TabIndex = 6;
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(184, 101);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(128, 42);
            this.buttonSair.TabIndex = 10;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // View_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 201);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonentrar);
            this.Controls.Add(this.textBoxnomeuser);
            this.Name = "View_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.View_Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonentrar;
        private System.Windows.Forms.TextBox textBoxnomeuser;
        private System.Windows.Forms.Button buttonSair;
    }
}

