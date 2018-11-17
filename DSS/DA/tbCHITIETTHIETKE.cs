namespace DSS.DA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbCHITIETTHIETKE")]
    public partial class tbCHITIETTHIETKE
    {
        public int id { get; set; }

        public int? tongsophong { get; set; }

        public int? solau { get; set; }

        public int? sophongkhach { get; set; }

        public int? sophongngu { get; set; }

        public int? sophongvesinh { get; set; }

        public int? sophongbep { get; set; }

        public int? id_thietke { get; set; }

        [Column("santruoc/sau")]
        [StringLength(10)]
        public string santruoc_sau { get; set; }

        public virtual tbTHIETKE tbTHIETKE { get; set; }
    }
}
