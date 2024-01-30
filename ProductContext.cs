using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChimChi
{
    class ProductContext : DbContext
    {
        public ProductContext()
            : base("DbConnection")
        {
            if (!ProductContexts.Any())
            {
                ProductContexts.Add(new Product
                {
                    Price = 200,
                    Duration = 2,
                    Name = "футболка"
                });
                SaveChanges();
            }
        }

        public DbSet<Product> ProductContexts { get; set; }
    }
}
