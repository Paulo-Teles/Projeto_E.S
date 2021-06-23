using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationAndLogin
{
    public class Utente : User
    {
        
        private readonly string _UserType;
        private string _Username;
        private string _Password;
        private string _Address;
        private string _FirstName;
        private string _Lastname;
        private string _Phonenumber;
        private DateTime _Borndate;
        private string _CC;
        [Key]
        public int _UtenteID { get; set; }
        public Utente(string username, string password, string address, string firstname, string lastname, string phonenumber, DateTime borndate, string cc)
        {
            _UserType = "Utente";
            _Username = username;
            _Password = password;
            _Address = address;
            _FirstName = firstname;
            _Lastname = lastname;
            _Phonenumber = phonenumber;
            _Borndate = borndate;
            _CC = cc;
        }

        public override string UserType { get { return _UserType; } }

        public override string Username { get { return _Username; } set { _Username = value; } }
        public override string Password { get { return _Password; } set { _Password = value; } }
        public override string Address { get { return _Address; } set { _Address = value; } }
        public override string FirstName { get { return _FirstName; } set { _FirstName = value; } }
        public override string Lastname { get { return _Lastname; } set { _Lastname = value; } }
        public override string Phonenumber { get { return _Phonenumber; } set { _Phonenumber = value; } }
        public override DateTime Borndate { get { return _Borndate; } set { _Borndate = value; } }
        public override string CC { get { return _CC; } set { _CC = value; } }

        public void Terapeuta_Acess(Terapeuta terapeuta)
        {

        }

        public void See_history()
        {

        }

        public void Check_date(DateTime data)
        {
            
        }
    }
}
