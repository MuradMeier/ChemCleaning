using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChimChi
{
    class ProcessingTypeContext : DbContext
    {
        public ProcessingTypeContext()
            : base("DbConnection")
        {
            if (!ProcessingTypes.Any())
            {
                ProcessingTypes.Add(new ProcessingType
                {
                    ProcessingType1 = "Выведение пятна",
                    ProcessingCofficient = 2
                });
                SaveChanges();
            }
        }

        public DbSet<ProcessingType> ProcessingTypes { get; set; }
    }
}
