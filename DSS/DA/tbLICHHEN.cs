namespace DSS.DA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbLICHHEN")]
    public partial class tbLICHHEN
    {
        public int id { get; set; }

        public int? id_khachhang { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay { get; set; }

        [StringLength(10)]
        public string gio { get; set; }

        public string ghichu { get; set; }

        public virtual tbKHACHHANG tbKHACHHANG { get; set; }
    }
}
