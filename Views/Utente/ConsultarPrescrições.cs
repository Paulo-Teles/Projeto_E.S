using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationAndLogin
{
    public partial class ConsultarPrescrições : Form
    {
        public ConsultarPrescrições()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Utente_Home MenuUtente = new Utente_Home();
            MenuUtente.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Procurar_Click(object sender, EventArgs e)
        {
            using (var context = new EFContext())
            {
                string procura = AProcurar.Value.ToString();
                procura = procura.Substring(0, procura.Length - 9);
                List<Prescricao> Procurar = context.Prescricaos.Where(prescricao => prescricao.CCUtente == Sessao.Logged.CC).Where(data => data.Validade.Contains(procura)).ToList();
                Informacao.DataSource = Procurar;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
