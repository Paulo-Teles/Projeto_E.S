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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Btnregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            using (var context = new EFContext())
            {
                var CasoSejaUtente = context.Utentes.Where(utente => utente.Username == txtusername.Text).Where(utente => utente.Password == txtpassword.Text);
                var CasoSejaTerapeuta = context.Terapeutas.Where(terapeuta => terapeuta.Username == txtusername.Text).Where(terapeuta => terapeuta.Password == txtpassword.Text);
                if (CasoSejaUtente.Any())
                {
                    this.Hide();
                    Utente_Home MenuUtente = new Utente_Home();
                    MenuUtente.ShowDialog();
                }
                if (CasoSejaTerapeuta.Any())
                {
                    this.Hide();
                    Terapeuta_Home MenuTerapeuta = new Terapeuta_Home();
                    MenuTerapeuta.ShowDialog();
                }
            }
        }
    }
}
