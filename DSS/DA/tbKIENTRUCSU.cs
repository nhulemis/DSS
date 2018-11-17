namespace DSS.DA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbKIENTRUCSU")]
    public partial class tbKIENTRUCSU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbKIENTRUCSU()
        {
            tbKIENTRUCTHIETKEs = new HashSet<tbKIENTRUCTHIETKE>();
            tbLUACHONTHIETKEs = new HashSet<tbLUACHONTHIETKE>();
        }

        public int id { get; set; }

        [StringLength(50)]
        public string ho { get; set; }

        [StringLength(50)]
        public string ten { get; set; }

        [StringLength(50)]
        public string diachi { get; set; }

        [StringLength(10)]
        public string lienhe { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string pass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbKIENTRUCTHIETKE> tbKIENTRUCTHIETKEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbLUACHONTHIETKE> tbLUACHONTHIETKEs { get; set; }
    }
}
