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
        /*
        public int PrescricaoID { get; set; }
        public Utente Utente  { get; set; }
        public Terapeuta AutorTerapeuta { get; set; }
        public List<Terapeuta> Terapeutas { get; set; }
        public List<Medicamento> Medicamentos { get; set; }
        public List<Exercicio> Exercicios { get; set; }
        public List<Tratamento> Tratamentos { get; set; }
        public DateTime Validade { get; set; }
        */
        public string CCUtente;
        public string CCAutorTerapeuta;
        public string Terapeutas;
        public string Medicamentos;
        public string Exercicios;
        public string Tratamentos;
        public DateTime Validade;

        [Key]
        public int PrescricaoID { get; set; }

        public Prescricao(string utente, string autorterapeuta, string terapeutas, string medicamentos, string exercicios, string tratamentos, DateTime validade){
            CCUtente = utente;
            CCAutorTerapeuta = autorterapeuta;
            Terapeutas= terapeutas;
            Medicamentos= medicamentos;
            Exercicios= exercicios;
            Tratamentos= tratamentos;
            Validade= validade;
        }


        public void Add_Medicamento() { }
    }
}
