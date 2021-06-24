﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationAndLogin
{
    public partial class HistoricoTerapeuta : Form
    {
        public HistoricoTerapeuta()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Informacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new EFContext())
            {
                List<Prescricao> Procurar = context.Prescricaos.Where(prescricao => prescricao.CCUtente == pesquisa.Text).Where(terapeuta => terapeuta.Terapeuta == Sessao.Logged.Username || terapeuta.CCAutorTerapeuta == Sessao.Logged.CC).ToList();
                Informacao.DataSource = Procurar;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Terapeuta_Home MenuTerapeuta = new Terapeuta_Home();
            MenuTerapeuta.ShowDialog();
        }
    }
}
