namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PivCardCertPolicy")]
    public partial class PivCardCertPolicy
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(256)]
        public string PolicyOid { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(256)]
        public string AgencyCodes { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool ApplyToPak { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool ApplyToCak { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool ApplyToCsc { get; set; }
    }
}
