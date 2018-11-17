namespace DSS.DA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbHINHANHTHIETKE")]
    public partial class tbHINHANHTHIETKE
    {
        public int id { get; set; }

        [Column(TypeName = "image")]
        public byte[] hinhanh { get; set; }

        public int? id_thietke { get; set; }

        public virtual tbTHIETKE tbTHIETKE { get; set; }
    }
}
