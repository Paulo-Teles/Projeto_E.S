using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationAndLogin
{
    public abstract class User
    {
        public abstract string UserType { get ; }
        public abstract string Username { get; set; }
        public abstract string Password { get; set; }
        public abstract string Address { get; set; }
        public abstract string FirstName { get; set; }
        public abstract string Lastname { get; set; }
        public abstract string Phonenumber { get; set; }
        public abstract DateTime Borndate { get; set; }
        public abstract string CC { get; set; }

    }
}
