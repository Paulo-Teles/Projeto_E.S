using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
namespace RegistrationAndLogin
{
    public class EFContext: DbContext
    {
        public DbSet<Terapeuta> Terapeutas { get; set; }
        public DbSet<Utente> Utentes { get; set; }
        public DbSet<Prescricao> Prescricoes { get; set; }
    }
}
