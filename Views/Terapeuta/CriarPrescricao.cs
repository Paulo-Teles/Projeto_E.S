using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationAndLogin
{
    public partial class CriarPrescricao : Form
    {
        public CriarPrescricao()
        {
            InitializeComponent();
        }

        private void CriarPrescricao_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DataPrescricao.Format = DateTimePickerFormat.Custom;
            DataPrescricao.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtCCUtente.Text != string.Empty)
            {
                using (var context = new EFContext())
                {
                    var CCExiste = context.Utentes.Where(utente => utente.CC == txtCCUtente.Text);
                    if (CCExiste.FirstOrDefault() != null) {
                        Prescricao prescricao = new Prescricao(CCExiste.First(), Sessao.Logged , "", txtMedicamentos.Text, txtExercicios.Text, txtTratamentos.Text, DataPrescricao.Value );
                        context.Prescricao.Add(prescricao);
                        context.SaveChanges();
                    }
                }
            }
            this.Hide();
            Terapeuta_Home MenuTerapeuta = new Terapeuta_Home();
            MenuTerapeuta.ShowDialog();
        }
            
    }
}
