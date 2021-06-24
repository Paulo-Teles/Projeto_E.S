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
    public partial class HistoricoPescrição : Form
    {
        public HistoricoPescrição()
        {
            InitializeComponent();
            using (var context = new EFContext())
            {
                List<Prescricao> Procurar = context.Prescricaos.Where(prescricao => prescricao.CCUtente == Sessao.Logged.CC).ToList();
                Informacao.DataSource = Procurar;
            }
        }

        private void Informacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Utente_Home MenuUtente = new Utente_Home();
            MenuUtente.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new EFContext())
            {
                var AModificar = context.Prescricaos.Where(prescricao => prescricao.PrescricaoID.ToString() == IdPrescricao.Text );
                if(AModificar != null)
                {
                    AModificar.First().Terapeuta = NovoTerapeuta.Text;
                }
                context.SaveChanges();
                
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
