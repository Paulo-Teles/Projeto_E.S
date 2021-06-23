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
            UserFactory factory = null;
            using (var context = new EFContext())
            {
                //var User = context.Utentes
                 //  .Where(s => s.Username == txtusername.Text)
                  // .FirstOrDefault<Utente>();
                //Console.WriteLine("teste de username" +User.Username);
                var CasoSejaUtente = context.Utentes.Where(utente => utente.Username == txtusername.Text).Where(utente => utente.Password == txtpassword.Text);

                var CasoSejaTerapeuta = context.Terapeutas.Where(terapeuta => terapeuta.Username == txtusername.Text).Where(terapeuta => terapeuta.Password == txtpassword.Text);
                if (CasoSejaUtente.Any())
                {
                    factory = new UtenteFactory(CasoSejaUtente.ElementAt(0).Username, CasoSejaUtente.ElementAt(0).Password, CasoSejaUtente.ElementAt(0).Address, CasoSejaUtente.ElementAt(0).FirstName, CasoSejaUtente.ElementAt(0).Lastname, CasoSejaUtente.ElementAt(0).Phonenumber, CasoSejaUtente.ElementAt(0).Borndate, CasoSejaUtente.ElementAt(0).CC);
                    User user = factory.GetUser();
                    this.Hide();
                    Utente_Home MenuUtente = new Utente_Home();
                    MenuUtente.ShowDialog();
                }
                if (CasoSejaTerapeuta.First().Username != String.Empty)
                {
                    factory = new TerapeutaFactory(CasoSejaTerapeuta.Username, CasoSejaTerapeuta.Password, CasoSejaTerapeuta.Address, CasoSejaTerapeuta.FirstName, CasoSejaTerapeuta.Lastname, CasoSejaTerapeuta.Phonenumber, CasoSejaTerapeuta.Borndate, CasoSejaTerapeuta.CC);
                    this.Hide();
                    Terapeuta_Home MenuTerapeuta = new Terapeuta_Home();
                    MenuTerapeuta.ShowDialog();
                }
            }
        }
    }
}
