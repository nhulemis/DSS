namespace DSS.DA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbTHIETKE")]
    public partial class tbTHIETKE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbTHIETKE()
        {
            tbCHIPHIs = new HashSet<tbCHIPHI>();
            tbCHITIETTHIETKEs = new HashSet<tbCHITIETTHIETKE>();
            tbHINHANHTHIETKEs = new HashSet<tbHINHANHTHIETKE>();
            tbKIENTRUCTHIETKEs = new HashSet<tbKIENTRUCTHIETKE>();
            tbLUACHONTHIETKEs = new HashSet<tbLUACHONTHIETKE>();
        }

        public int id { get; set; }

        [StringLength(50)]
        public string ten { get; set; }

        public int? dai { get; set; }

        public int? rong { get; set; }

        public int? id_danhmuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCHIPHI> tbCHIPHIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCHITIETTHIETKE> tbCHITIETTHIETKEs { get; set; }

        public virtual tbDANHMUCTHIETKE tbDANHMUCTHIETKE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHINHANHTHIETKE> tbHINHANHTHIETKEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbKIENTRUCTHIETKE> tbKIENTRUCTHIETKEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbLUACHONTHIETKE> tbLUACHONTHIETKEs { get; set; }
    }
}
