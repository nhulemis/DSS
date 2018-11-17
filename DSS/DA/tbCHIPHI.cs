namespace DSS.DA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbCHIPHI")]
    public partial class tbCHIPHI
    {
        public int id { get; set; }

        public int? id_thietke { get; set; }

        public int? gach { get; set; }

        public int? xi { get; set; }

        [StringLength(10)]
        public string soicat { get; set; }

        public int? son { get; set; }

        public int? gachlot { get; set; }

        public double? uoctinhchiphi { get; set; }

        public virtual tbTHIETKE tbTHIETKE { get; set; }
    }
}
