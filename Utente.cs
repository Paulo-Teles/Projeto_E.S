using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationAndLogin
{
    public class Utente
    {
        public int UtenteID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Phonenumber { get; set; }
        public DateTime Borndate { get; set; }
        public string CC { get; set; }



        public void Terapeuta_Acess(Terapeuta terapeuta)
        {

        }
    }
}
