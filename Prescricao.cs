using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationAndLogin
{
    class Prescricao
    {
        public Utente Utente { get; set; }
        public List<Tratamento> Tratamentos { get; set; }
        public List<Medicamento> Medicamentos { get; set; }
        public List<Exercício> Exercícios { get; set; }
        public Terapeuta Terapeuta { get; set; }
        public DateTime Data;
        public string Medicamentos_info;


        public Prescricao(Utente utente, List<Tratamento> tratamentos, List<Medicamento> medicamentos, List<Exercício> exercícios, Terapeuta terapeuta, DateTime data, string medicamentos_info)
        {
            this.Utente = utente;
            this.Tratamentos = tratamentos;
            this.Medicamentos = medicamentos;
            this.Exercícios = exercícios;
            this.Terapeuta = terapeuta;
            this.Data = data;
            this.Medicamentos_info = medicamentos_info;
        }


        public void Add_Medicamento(Medicamento medicamento)
        {
            Medicamentos.Add(medicamento);
        }

        public void Add_Tratamento(Tratamento tratamento)
        {
            Tratamentos.Add(tratamento);
        }

        public void Add_Exercicios(Exercício exercício)
        {
            Exercícios.Add(exercício);
        }


        public void Remove_Medicamento(Medicamento medicamento)
        {
            Medicamentos.Remove(medicamento);
        }

        public void Remove_Tratamento(Tratamento tratamento)
        {
            Tratamentos.Remove(tratamento);
        }

        public void Remove_Exercicios(Exercício exercício)
        {
            Exercícios.Remove(exercício);
        }


    }
}
