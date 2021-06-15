using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationAndLogin
{
    class Terapeuta_Acess_Command
    {
        Utente utente;
        Terapeuta terapeuta;

        public Terapeuta_Acess_Command(Utente utente_, Terapeuta terapeuta_)
        {
            this.utente = utente_;
            this.terapeuta = terapeuta_;
        }

        public void execute()
        {
            this.utente.Terapeuta_Acess(terapeuta);
        }
    }
}
