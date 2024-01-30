namespace ChimChi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public Product()
        {
            OrderComposition = new HashSet<OrderComposition>();
        }

        public int ID { get; set; }

        public double Price { get; set; }

        public double Duration { get; set; }

        public string Name { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderComposition> OrderComposition { get; set; }
    }
}
