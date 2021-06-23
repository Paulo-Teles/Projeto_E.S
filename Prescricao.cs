using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationAndLogin
{
    public class Prescricao
    {
        public int PrescricaoID { get; set; }
        public Utente Utente  { get; set; }
        public Terapeuta AutorTerapeuta { get; set; }
        public List<Terapeuta> Terapeutas { get; set; }
        public List<Medicamento> Medicamentos { get; set; }
        public List<Exercicio> Exercicios { get; set; }
        public List<Tratamento> Tratamentos { get; set; }
        public DateTime Validade { get; set; }
    }
}
