using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationAndLogin
{
    class Tratamento
    {
        public string Name { get; set; }
        public DateTime Data { get; set; }

        public Tratamento(string name, DateTime data)
        {
            this.Name = name;
            this.Data = data;
        }
    }
}
