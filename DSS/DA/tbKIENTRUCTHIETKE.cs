namespace DSS.DA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbKIENTRUCTHIETKE")]
    public partial class tbKIENTRUCTHIETKE
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kientrucsu { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_thietke { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay { get; set; }

        public virtual tbKIENTRUCSU tbKIENTRUCSU { get; set; }

        public virtual tbTHIETKE tbTHIETKE { get; set; }
    }
}
