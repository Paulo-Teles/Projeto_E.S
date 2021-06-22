using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationAndLogin
{
    public class TerapeutaCommand : ICommand
    {
        Terapeuta terapeuta;

        public TerapeutaCommand(Terapeuta terapeuta)
        {
            this.terapeuta = terapeuta;
        }
        public void Execute()
        {
           
        }
    }
}
