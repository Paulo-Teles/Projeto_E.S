
namespace RegistrationAndLogin
{
    partial class ConsultarPrescrições
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
            this.lbMedicamento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbExercicio = new System.Windows.Forms.Label();
            this.lbTratamento = new System.Windows.Forms.Label();
            this.btnVoltaratras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMedicamento
            // 
            this.lbMedicamento.AutoSize = true;
            this.lbMedicamento.Location = new System.Drawing.Point(66, 129);
            this.lbMedicamento.Name = "lbMedicamento";
            this.lbMedicamento.Size = new System.Drawing.Size(96, 17);
            this.lbMedicamento.TabIndex = 0;
            this.lbMedicamento.Text = "Medicamento:";
            this.lbMedicamento.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbExercicio
            // 
            this.lbExercicio.AutoSize = true;
            this.lbExercicio.Location = new System.Drawing.Point(66, 214);
            this.lbExercicio.Name = "lbExercicio";
            this.lbExercicio.Size = new System.Drawing.Size(68, 17);
            this.lbExercicio.TabIndex = 4;
            this.lbExercicio.Text = "Exercicio:";
            this.lbExercicio.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbTratamento
            // 
            this.lbTratamento.AutoSize = true;
            this.lbTratamento.Location = new System.Drawing.Point(66, 316);
            this.lbTratamento.Name = "lbTratamento";
            this.lbTratamento.Size = new System.Drawing.Size(85, 17);
            this.lbTratamento.TabIndex = 5;
            this.lbTratamento.Text = "Tratamento:";
            this.lbTratamento.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnVoltaratras
            // 
            this.btnVoltaratras.Location = new System.Drawing.Point(377, 563);
            this.btnVoltaratras.Name = "btnVoltaratras";
            this.btnVoltaratras.Size = new System.Drawing.Size(107, 73);
            this.btnVoltaratras.TabIndex = 6;
            this.btnVoltaratras.Text = "Voltar atrás";
            this.btnVoltaratras.UseVisualStyleBackColor = true;
            this.btnVoltaratras.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultarPrescrições
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 683);
            this.Controls.Add(this.btnVoltaratras);
            this.Controls.Add(this.lbTratamento);
            this.Controls.Add(this.lbExercicio);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMedicamento);
            this.Name = "ConsultarPrescrições";
            this.Text = "ConsultarPrescrições";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMedicamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbExercicio;
        private System.Windows.Forms.Label lbTratamento;
        private System.Windows.Forms.Button btnVoltaratras;
    }
}