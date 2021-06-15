using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationAndLogin
{
    class Invoker
    {
        ICommand Terapeuta_Acess;
        ICommand Show_Prescricoes;
        ICommand New_Prescricao;
        ICommand Start_Session;

        public Invoker( ICommand Terapeuta_Acess_, ICommand Show_Prescricoes_, ICommand New_Prescricao_, ICommand Start_Session_)
        {
            this.Terapeuta_Acess = Terapeuta_Acess_;
            this.Show_Prescricoes = Show_Prescricoes_;
            this.New_Prescricao = New_Prescricao_;
            this.Start_Session = Start_Session_;
        }

        public void Give_Terapeuta_Acess()
        {
            this.Terapeuta_Acess.execute();
        }

        public void Display_Prescriptions()
        {
            this.Show_Prescricoes.execute();
        }

        public void Add_Prescription()
        {
            this.New_Prescricao.execute();
        }

        public void Start_THe_Session()
        {
            this.Start_Session.execute();
        }
    }
}
