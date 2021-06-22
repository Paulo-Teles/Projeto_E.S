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
    public partial class Terapeuta_Home : Form
    {
        public Terapeuta_Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistoricoTerapeuta HistoricoTerapeuta = new HistoricoTerapeuta();
            HistoricoTerapeuta.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CriarPrescricao CriarPrescricao = new CriarPrescricao();
            CriarPrescricao.ShowDialog();
        }
    }
}
