using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ChimChi
{
    public partial class Cleaner : DbContext
    {
        public Cleaner()
            : base("name=Cleaner")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderComposition> OrderComposition { get; set; }
        public virtual DbSet<ProcessingType> ProcessingType { get; set; }
        public virtual DbSet<Product> Product { get; set; }
    }
}
