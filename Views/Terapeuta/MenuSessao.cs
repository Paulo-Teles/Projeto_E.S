using System;
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
    public partial class MenuSessao : Form
    {
        public MenuSessao()
        {
            InitializeComponent();
            using (var context = new EFContext())
            {
                List<Prescricao> Procurar = context.Prescricaos.Where(prescricao => prescricao.Terapeuta == Sessao.Logged.Username || prescricao.CCAutorTerapeuta == Sessao.Logged.CC).ToList();
                TratamentosAcesso.DataSource = Procurar;
            }
        }

        private void SessaoTerapeuta_Load(object sender, EventArgs e)
        {

        }

        private void Inserir_Click(object sender, EventArgs e)
        {
            using (var contextAdd = new EFContext())
            {
                Session session = new Session(int.Parse(PrescricaoID.Text), Nota.Text);
                contextAdd.Sessions.Add(session);
                contextAdd.SaveChanges();
            }
        }

        private void TratamentosAcesso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Nota_TextChanged(object sender, EventArgs e)
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
