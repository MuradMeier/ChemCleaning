namespace ChimChi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client
    {
        public Client()
        {
            Order1 = new HashSet<Order>();
        }

        public int ID { get; set; }

        public string Surname { get; set; }

        public string Name { get; set; }

        public string Patronymic { get; set; }

        public string Number { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public int House { get; set; }

        public int Apartment { get; set; }

        public virtual Order Order { get; set; }

        public virtual ICollection<Order> Order1 { get; set; }
    }
}
