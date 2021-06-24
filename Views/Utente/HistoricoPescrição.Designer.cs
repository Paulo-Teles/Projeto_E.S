
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
            ((System.ComponentModel.ISupportInitialize)(this.Informacao)).BeginInit();
            this.SuspendLayout();
            // 
            // Informacao
            // 
            this.Informacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Informacao.Location = new System.Drawing.Point(32, 12);
            this.Informacao.Name = "Informacao";
            this.Informacao.Size = new System.Drawing.Size(966, 315);
            this.Informacao.TabIndex = 4;
            this.Informacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Informacao_CellContentClick);
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(334, 351);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(327, 50);
            this.Voltar.TabIndex = 5;
            this.Voltar.Text = "Voltar ao menu";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // HistoricoPescrição
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 426);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Informacao);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HistoricoPescrição";
            this.Text = "Historico";
            ((System.ComponentModel.ISupportInitialize)(this.Informacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Informacao;
        private System.Windows.Forms.Button Voltar;
    }
}