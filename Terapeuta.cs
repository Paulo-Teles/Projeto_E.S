using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationAndLogin
{
    public class Terapeuta : User
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
        public int TerapeutaID { get; set; }
        public Terapeuta(string username, string password, string address, string firstname, string lastname, string phonenumber, DateTime borndate, string cc)
        {
            _UserType = "Terapeuta";
            _Username = username;
            _Password = password;
            _Address = address;
            _FirstName = firstname;
            _Lastname = lastname;
            _Phonenumber = phonenumber;
            _Borndate = borndate;
            _CC = cc;
        }

        public Terapeuta()
        {
            
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

        public void New_Prescription(Prescricao prescricao, Utente utente)
        {

        }

        public void Start_Session(Utente utente)
        {

        }

        public void See_history(Utente utente)
        {

        }
    }
}
