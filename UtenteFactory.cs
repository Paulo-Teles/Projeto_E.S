using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationAndLogin
{
    class UtenteFactory : UserFactory
    {
        private string _Username;
        private string _Password;
        private string _Address;
        private string _FirstName;
        private string _Lastname;
        private string _Phonenumber;
        private DateTime _Borndate;
        private string _CC;



        public UtenteFactory(string username, string password, string address, string firstname, string lastname, string phonenumber, DateTime borndate, string cc)
        {
            _Username = username;
            _Password = password;
            _Address = address;
            _FirstName = firstname;
            _Lastname = lastname;
            _Phonenumber = phonenumber;
            _Borndate = borndate;
            _CC = cc;
        }


        public override User GetUser()
        {
            return new Utente(_Username, _Password, _Address, _FirstName, _Lastname, _Phonenumber, _Borndate, _CC);
        }
    }
}
