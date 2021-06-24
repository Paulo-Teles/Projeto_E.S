
namespace RegistrationAndLogin.Views.Terapeuta
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
            this.IdPrescricao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Inserir = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            // 
            // IdPrescricao
            // 
            this.IdPrescricao.AutoSize = true;
            this.IdPrescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IdPrescricao.Location = new System.Drawing.Point(16, 132);
            this.IdPrescricao.Name = "IdPrescricao";
            this.IdPrescricao.Size = new System.Drawing.Size(122, 20);
            this.IdPrescricao.TabIndex = 1;
            this.IdPrescricao.Text = "Id da prescrição";
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(144, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Inserir
            // 
            this.Inserir.Location = new System.Drawing.Point(582, 261);
            this.Inserir.Name = "Inserir";
            this.Inserir.Size = new System.Drawing.Size(163, 48);
            this.Inserir.TabIndex = 4;
            this.Inserir.Text = "Inserir";
            this.Inserir.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 204);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(480, 205);
            this.textBox2.TabIndex = 5;
            // 
            // SessaoTerapeuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Inserir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdPrescricao);
            this.Controls.Add(this.TratamentosAcesso);
            this.Name = "SessaoTerapeuta";
            this.Text = "SessaoTerapeuta";
            this.Load += new System.EventHandler(this.SessaoTerapeuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TratamentosAcesso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TratamentosAcesso;
        private System.Windows.Forms.Label IdPrescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Inserir;
        private System.Windows.Forms.TextBox textBox2;
    }
}