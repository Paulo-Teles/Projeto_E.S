using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationAndLogin
{
    public class Session
    {
        public int IdDaPrescricao { get; set; }
        public string Notas { get; set; }
        [Key]
        public int UtenteID { get; set; }

        public Session(int QualPrescricao, string Nota)
        {
            IdDaPrescricao = QualPrescricao;
            Notas = Nota;
        }

        private Session()
        {

        }
    }
}
