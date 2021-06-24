using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationAndLogin
{
    public class Prescricao
    {
        
        public string CCUtente { get; set; }
        public string CCAutorTerapeuta { get; set; }
        public string Terapeuta { get; set; }
        public string Medicamentos { get; set; }
        public string Exercicios { get; set; }
        public string Tratamentos { get; set; }
        public DateTime Validade { get;  set; }

        [Key]
        public int PrescricaoID { get; set; }

        public Prescricao(string utente, string autorterapeuta, string terapeutas, string medicamentos, string exercicios, string tratamentos, DateTime validade){
            CCUtente = utente;
            CCAutorTerapeuta = autorterapeuta;
            Terapeuta= terapeutas;
            Medicamentos= medicamentos;
            Exercicios= exercicios;
            Tratamentos= tratamentos;
            Validade= validade;
        }

        private Prescricao()
        {
            
        }

        public void Add_Medicamento() { }
    }
}
