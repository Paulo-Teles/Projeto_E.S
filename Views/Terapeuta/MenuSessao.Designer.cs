
namespace RegistrationAndLogin
{
    partial class MenuSessao
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
            this.TratamentosAcesso = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrescricaoID = new System.Windows.Forms.TextBox();
            this.Inserir = new System.Windows.Forms.Button();
            this.Nota = new System.Windows.Forms.TextBox();
            this.Voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TratamentosAcesso)).BeginInit();
            this.SuspendLayout();
            // 
            // TratamentosAcesso
            // 
            this.TratamentosAcesso.AllowUserToAddRows = false;
            this.TratamentosAcesso.AllowUserToDeleteRows = false;
            this.TratamentosAcesso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TratamentosAcesso.Location = new System.Drawing.Point(16, 22);
            this.TratamentosAcesso.Name = "TratamentosAcesso";
            this.TratamentosAcesso.ReadOnly = true;
            this.TratamentosAcesso.Size = new System.Drawing.Size(770, 88);
            this.TratamentosAcesso.TabIndex = 0;
            this.TratamentosAcesso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TratamentosAcesso_CellContentClick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label.Location = new System.Drawing.Point(16, 132);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(122, 20);
            this.label.TabIndex = 1;
            this.label.Text = "Id da prescrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(16, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notas:";
            // 
            // PrescricaoID
            // 
            this.PrescricaoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PrescricaoID.Location = new System.Drawing.Point(144, 134);
            this.PrescricaoID.Name = "PrescricaoID";
            this.PrescricaoID.Size = new System.Drawing.Size(187, 20);
            this.PrescricaoID.TabIndex = 3;
            // 
            // Inserir
            // 
            this.Inserir.Location = new System.Drawing.Point(583, 225);
            this.Inserir.Name = "Inserir";
            this.Inserir.Size = new System.Drawing.Size(163, 48);
            this.Inserir.TabIndex = 4;
            this.Inserir.Text = "Inserir";
            this.Inserir.UseVisualStyleBackColor = true;
            this.Inserir.Click += new System.EventHandler(this.Inserir_Click);
            // 
            // Nota
            // 
            this.Nota.Location = new System.Drawing.Point(18, 204);
            this.Nota.Multiline = true;
            this.Nota.Name = "Nota";
            this.Nota.Size = new System.Drawing.Size(480, 205);
            this.Nota.TabIndex = 5;
            this.Nota.TextChanged += new System.EventHandler(this.Nota_TextChanged);
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(584, 309);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(161, 48);
            this.Voltar.TabIndex = 6;
            this.Voltar.Text = "Voltar ao menu";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // MenuSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Nota);
            this.Controls.Add(this.Inserir);
            this.Controls.Add(this.PrescricaoID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.TratamentosAcesso);
            this.Name = "MenuSessao";
            this.Text = "SessaoTerapeuta";
            this.Load += new System.EventHandler(this.SessaoTerapeuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TratamentosAcesso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TratamentosAcesso;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrescricaoID;
        private System.Windows.Forms.Button Inserir;
        private System.Windows.Forms.TextBox Nota;
        private System.Windows.Forms.Button Voltar;
    }
}