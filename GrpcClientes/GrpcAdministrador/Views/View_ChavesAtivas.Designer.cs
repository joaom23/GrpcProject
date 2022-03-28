
namespace GrpcUtilizadores.Views
{
    partial class View_ChavesAtivas
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewChavesAnteriores = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estrela1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estrela2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDaAposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotalChavesAtivas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChavesAnteriores)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewChavesAnteriores
            // 
            this.dataGridViewChavesAnteriores.AllowUserToAddRows = false;
            this.dataGridViewChavesAnteriores.AllowUserToDeleteRows = false;
            this.dataGridViewChavesAnteriores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewChavesAnteriores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChavesAnteriores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChavesAnteriores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Numero1,
            this.Numero2,
            this.Numero3,
            this.Numero4,
            this.Numero5,
            this.Estrela1,
            this.Estrela2,
            this.DataDaAposta});
            this.dataGridViewChavesAnteriores.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewChavesAnteriores.Location = new System.Drawing.Point(12, 66);
            this.dataGridViewChavesAnteriores.Name = "dataGridViewChavesAnteriores";
            this.dataGridViewChavesAnteriores.ReadOnly = true;
            this.dataGridViewChavesAnteriores.RowHeadersWidth = 51;
            this.dataGridViewChavesAnteriores.RowTemplate.Height = 29;
            this.dataGridViewChavesAnteriores.Size = new System.Drawing.Size(1069, 299);
            this.dataGridViewChavesAnteriores.TabIndex = 6;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Numero1
            // 
            this.Numero1.HeaderText = "Numero1";
            this.Numero1.MinimumWidth = 6;
            this.Numero1.Name = "Numero1";
            this.Numero1.ReadOnly = true;
            // 
            // Numero2
            // 
            this.Numero2.HeaderText = "Numero2";
            this.Numero2.MinimumWidth = 6;
            this.Numero2.Name = "Numero2";
            this.Numero2.ReadOnly = true;
            // 
            // Numero3
            // 
            this.Numero3.HeaderText = "Numero3";
            this.Numero3.MinimumWidth = 6;
            this.Numero3.Name = "Numero3";
            this.Numero3.ReadOnly = true;
            // 
            // Numero4
            // 
            this.Numero4.HeaderText = "Numero4";
            this.Numero4.MinimumWidth = 6;
            this.Numero4.Name = "Numero4";
            this.Numero4.ReadOnly = true;
            // 
            // Numero5
            // 
            this.Numero5.HeaderText = "Numero5";
            this.Numero5.MinimumWidth = 6;
            this.Numero5.Name = "Numero5";
            this.Numero5.ReadOnly = true;
            // 
            // Estrela1
            // 
            this.Estrela1.HeaderText = "Estrela1";
            this.Estrela1.MinimumWidth = 6;
            this.Estrela1.Name = "Estrela1";
            this.Estrela1.ReadOnly = true;
            // 
            // Estrela2
            // 
            this.Estrela2.HeaderText = "Estrela2";
            this.Estrela2.MinimumWidth = 6;
            this.Estrela2.Name = "Estrela2";
            this.Estrela2.ReadOnly = true;
            // 
            // DataDaAposta
            // 
            this.DataDaAposta.HeaderText = "DataDaAposta";
            this.DataDaAposta.MinimumWidth = 6;
            this.DataDaAposta.Name = "DataDaAposta";
            this.DataDaAposta.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(365, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chaves Ativas Para o Sorteio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total: ";
            // 
            // labelTotalChavesAtivas
            // 
            this.labelTotalChavesAtivas.AutoSize = true;
            this.labelTotalChavesAtivas.Location = new System.Drawing.Point(58, 375);
            this.labelTotalChavesAtivas.Name = "labelTotalChavesAtivas";
            this.labelTotalChavesAtivas.Size = new System.Drawing.Size(17, 20);
            this.labelTotalChavesAtivas.TabIndex = 9;
            this.labelTotalChavesAtivas.Text = "0";
            // 
            // View_ChavesAtivas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 450);
            this.Controls.Add(this.labelTotalChavesAtivas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewChavesAnteriores);
            this.Controls.Add(this.button1);
            this.Name = "View_ChavesAtivas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chaves Anteriores";
            this.Load += new System.EventHandler(this.View_ChavesAtivas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChavesAnteriores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewChavesAnteriores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotalChavesAtivas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estrela1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estrela2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDaAposta;
    }
}