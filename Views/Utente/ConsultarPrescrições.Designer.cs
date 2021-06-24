
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
            this.label2 = new System.Windows.Forms.Label();
            this.AProcurar = new System.Windows.Forms.DateTimePicker();
            this.btnVoltaratras = new System.Windows.Forms.Button();
            this.Informacao = new System.Windows.Forms.DataGridView();
            this.Procurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Informacao)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AProcurar
            // 
            this.AProcurar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AProcurar.Location = new System.Drawing.Point(95, 39);
            this.AProcurar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AProcurar.Name = "AProcurar";
            this.AProcurar.Size = new System.Drawing.Size(151, 20);
            this.AProcurar.TabIndex = 3;
            this.AProcurar.Value = new System.DateTime(2021, 6, 24, 0, 0, 0, 0);
            this.AProcurar.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnVoltaratras
            // 
            this.btnVoltaratras.Location = new System.Drawing.Point(283, 457);
            this.btnVoltaratras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoltaratras.Name = "btnVoltaratras";
            this.btnVoltaratras.Size = new System.Drawing.Size(80, 59);
            this.btnVoltaratras.TabIndex = 6;
            this.btnVoltaratras.Text = "Voltar atrás";
            this.btnVoltaratras.UseVisualStyleBackColor = true;
            this.btnVoltaratras.Click += new System.EventHandler(this.button1_Click);
            // 
            // Informacao
            // 
            this.Informacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Informacao.Location = new System.Drawing.Point(50, 96);
            this.Informacao.Name = "Informacao";
            this.Informacao.Size = new System.Drawing.Size(541, 330);
            this.Informacao.TabIndex = 7;
            this.Informacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Procurar
            // 
            this.Procurar.Location = new System.Drawing.Point(251, 37);
            this.Procurar.Name = "Procurar";
            this.Procurar.Size = new System.Drawing.Size(191, 28);
            this.Procurar.TabIndex = 8;
            this.Procurar.Text = "Lookup";
            this.Procurar.UseVisualStyleBackColor = true;
            this.Procurar.Click += new System.EventHandler(this.Procurar_Click);
            // 
            // ConsultarPrescrições
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 555);
            this.Controls.Add(this.Procurar);
            this.Controls.Add(this.Informacao);
            this.Controls.Add(this.btnVoltaratras);
            this.Controls.Add(this.AProcurar);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultarPrescrições";
            this.Text = "ConsultarPrescrições";
            ((System.ComponentModel.ISupportInitialize)(this.Informacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker AProcurar;
        private System.Windows.Forms.Button btnVoltaratras;
        private System.Windows.Forms.DataGridView Informacao;
        private System.Windows.Forms.Button Procurar;
    }
}