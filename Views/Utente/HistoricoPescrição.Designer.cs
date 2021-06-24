
namespace RegistrationAndLogin
{
    partial class HistoricoPescrição
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
            this.Informacao = new System.Windows.Forms.DataGridView();
            this.Voltar = new System.Windows.Forms.Button();
            this.IdPrescricao = new System.Windows.Forms.TextBox();
            this.NovoTerapeuta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Informacao)).BeginInit();
            this.SuspendLayout();
            // 
            // Informacao
            // 
            this.Informacao.AllowUserToAddRows = false;
            this.Informacao.AllowUserToDeleteRows = false;
            this.Informacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Informacao.Location = new System.Drawing.Point(32, 12);
            this.Informacao.Name = "Informacao";
            this.Informacao.ReadOnly = true;
            this.Informacao.Size = new System.Drawing.Size(966, 315);
            this.Informacao.TabIndex = 4;
            this.Informacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Informacao_CellContentClick);
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(32, 353);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(327, 50);
            this.Voltar.TabIndex = 5;
            this.Voltar.Text = "Voltar ao menu";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // IdPrescricao
            // 
            this.IdPrescricao.Location = new System.Drawing.Point(658, 353);
            this.IdPrescricao.Name = "IdPrescricao";
            this.IdPrescricao.Size = new System.Drawing.Size(230, 20);
            this.IdPrescricao.TabIndex = 6;
            // 
            // NovoTerapeuta
            // 
            this.NovoTerapeuta.Location = new System.Drawing.Point(658, 383);
            this.NovoTerapeuta.Name = "NovoTerapeuta";
            this.NovoTerapeuta.Size = new System.Drawing.Size(230, 20);
            this.NovoTerapeuta.TabIndex = 7;
            this.NovoTerapeuta.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(913, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(521, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Novo terapeuta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(517, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Id da prescrição";
            // 
            // HistoricoPescrição
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 426);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NovoTerapeuta);
            this.Controls.Add(this.IdPrescricao);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Informacao);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HistoricoPescrição";
            this.Text = "Historico";
            ((System.ComponentModel.ISupportInitialize)(this.Informacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Informacao;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.TextBox IdPrescricao;
        private System.Windows.Forms.TextBox NovoTerapeuta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}