using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationAndLogin
{
    class Terapeuta
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CC { get; set; }
        public string BornDate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Terapeuta(string firstname, string lastname, string cc, string borndate, string address, string phonenumber)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.CC = cc;
            this.BornDate = borndate;
            this.Address = address;
            this.PhoneNumber = phonenumber;
        }
        public void New_Prescription()
        {

        }

        public void showPrescription(Prescricao prescricao, Utente utente)
        {

        }

        public void Start_Session()
        {

        }
    }
}
