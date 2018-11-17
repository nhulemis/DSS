namespace DSS.DA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbDANHMUCTHIETKE")]
    public partial class tbDANHMUCTHIETKE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbDANHMUCTHIETKE()
        {
            tbTHIETKEs = new HashSet<tbTHIETKE>();
        }

        public int id { get; set; }

        [StringLength(50)]
        public string ten { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTHIETKE> tbTHIETKEs { get; set; }
    }
}
