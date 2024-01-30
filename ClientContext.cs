using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChimChi
{
    class ClientContext : DbContext
    {
        public ClientContext()
            : base("DbConnection")
        {
            if (!Clients.Any())
            {
                Clients.Add(new Client 
                { 
                    Name = "Ivan",
                    Surname="Ivanov",
                    Patronymic="Ivanovich",
                    Number="89063795603",
                    Street="Nekrasova",
                    House=12,
                    Apartment=2 
                });
                SaveChanges();
            }
        }

        public DbSet<Client> Clients { get; set; }
    }
}
