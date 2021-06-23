
namespace RegistrationAndLogin
{
    partial class CriarPrescricao
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCCUtente = new System.Windows.Forms.TextBox();
            this.DataPrescricao = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTratamentos = new System.Windows.Forms.TextBox();
            this.txtExercicios = new System.Windows.Forms.TextBox();
            this.txtMedicamentos = new System.Windows.Forms.TextBox();
            this.BotaoCriarPrescricao = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "CC do Utente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCCUtente
            // 
            this.txtCCUtente.Location = new System.Drawing.Point(178, 33);
            this.txtCCUtente.Name = "txtCCUtente";
            this.txtCCUtente.Size = new System.Drawing.Size(278, 20);
            this.txtCCUtente.TabIndex = 2;
            // 
            // DataPrescricao
            // 
            this.DataPrescricao.AllowDrop = true;
            this.DataPrescricao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataPrescricao.Location = new System.Drawing.Point(177, 78);
            this.DataPrescricao.Name = "DataPrescricao";
            this.DataPrescricao.Size = new System.Drawing.Size(278, 20);
            this.DataPrescricao.TabIndex = 3;
            this.DataPrescricao.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Em que dia";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tratamentos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Exercicios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Medicamentos";
            // 
            // txtTratamentos
            // 
            this.txtTratamentos.Location = new System.Drawing.Point(177, 128);
            this.txtTratamentos.Name = "txtTratamentos";
            this.txtTratamentos.Size = new System.Drawing.Size(278, 20);
            this.txtTratamentos.TabIndex = 8;
            // 
            // txtExercicios
            // 
            this.txtExercicios.Location = new System.Drawing.Point(177, 165);
            this.txtExercicios.Name = "txtExercicios";
            this.txtExercicios.Size = new System.Drawing.Size(278, 20);
            this.txtExercicios.TabIndex = 9;
            // 
            // txtMedicamentos
            // 
            this.txtMedicamentos.Location = new System.Drawing.Point(177, 198);
            this.txtMedicamentos.Name = "txtMedicamentos";
            this.txtMedicamentos.Size = new System.Drawing.Size(278, 20);
            this.txtMedicamentos.TabIndex = 10;
            // 
            // BotaoCriarPrescricao
            // 
            this.BotaoCriarPrescricao.Location = new System.Drawing.Point(177, 270);
            this.BotaoCriarPrescricao.Name = "BotaoCriarPrescricao";
            this.BotaoCriarPrescricao.Size = new System.Drawing.Size(297, 58);
            this.BotaoCriarPrescricao.TabIndex = 11;
            this.BotaoCriarPrescricao.Text = "Criar";
            this.BotaoCriarPrescricao.UseVisualStyleBackColor = true;
            this.BotaoCriarPrescricao.Click += new System.EventHandler(this.button1_Click);
            // 
            // CriarPrescricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotaoCriarPrescricao);
            this.Controls.Add(this.txtMedicamentos);
            this.Controls.Add(this.txtExercicios);
            this.Controls.Add(this.txtTratamentos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataPrescricao);
            this.Controls.Add(this.txtCCUtente);
            this.Controls.Add(this.label1);
            this.Name = "CriarPrescricao";
            this.Text = "Criar Prescrição";
            this.Load += new System.EventHandler(this.CriarPrescricao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCCUtente;
        private System.Windows.Forms.DateTimePicker DataPrescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTratamentos;
        private System.Windows.Forms.TextBox txtExercicios;
        private System.Windows.Forms.TextBox txtMedicamentos;
        private System.Windows.Forms.Button BotaoCriarPrescricao;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}