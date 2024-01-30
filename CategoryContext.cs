using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChimChi
{
    class CategoryContext: DbContext
    {
        public CategoryContext() 
            :base("DbConnection")
        {
            if (!Categories.Any())
            {
                Categories.Add(new Category{Name="One"});
                SaveChanges();
            }
        }

        public DbSet<Category> Categories { get; set; }
    }
}
