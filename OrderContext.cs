using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChimChi
{
    class OrderContext : DbContext
    {
        public OrderContext()
            : base("DbConnection")
        {
            if (!Orders.Any())
            {
                Orders.Add(new Order
                {
                    CompilationDate = DateTime.Now,
                    TotalDuration = 1,
                    OrderPrice = 200,
                    Issue = false,
                    Readiness = false
                });
                SaveChanges();
            }
        }

        public DbSet<Order> Orders { get; set; }
    }
}
