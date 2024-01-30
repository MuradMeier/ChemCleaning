namespace ChimChi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcessingType")]
    public partial class ProcessingType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProcessingType()
        {
            OrderComposition = new HashSet<OrderComposition>();
        }

        public int ID { get; set; }

        [Column("ProcessingType")]
        [Required]
        [StringLength(50)]
        public string ProcessingType1 { get; set; }

        public double ProcessingCofficient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderComposition> OrderComposition { get; set; }
    }
}
