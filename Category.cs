namespace ChimChi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Category
    {
        public Category()
        {
            Product = new HashSet<Product>();
        }

        public int ID { get; set; }

        public string Name { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
