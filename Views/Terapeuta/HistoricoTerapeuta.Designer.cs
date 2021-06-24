
namespace RegistrationAndLogin
{
    partial class HistoricoTerapeuta
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
            this.pesquisa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Informacao = new System.Windows.Forms.DataGridView();
            this.Voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Informacao)).BeginInit();
            this.SuspendLayout();
            // 
            // pesquisa
            // 
            this.pesquisa.Location = new System.Drawing.Point(47, 42);
            this.pesquisa.Name = "pesquisa";
            this.pesquisa.Size = new System.Drawing.Size(167, 20);
            this.pesquisa.TabIndex = 0;
            this.pesquisa.Text = "Pesquisa";
            this.pesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lookup";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Informacao
            // 
            this.Informacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Informacao.Location = new System.Drawing.Point(40, 122);
            this.Informacao.Name = "Informacao";
            this.Informacao.Size = new System.Drawing.Size(698, 279);
            this.Informacao.TabIndex = 2;
            this.Informacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(481, 28);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(152, 47);
            this.Voltar.TabIndex = 3;
            this.Voltar.Text = "Voltar ao menu";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // HistoricoTerapeuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Informacao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pesquisa);
            this.Name = "HistoricoTerapeuta";
            this.Text = "HistoricoTerapeuta";
            ((System.ComponentModel.ISupportInitialize)(this.Informacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pesquisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Informacao;
        private System.Windows.Forms.Button Voltar;
    }
}