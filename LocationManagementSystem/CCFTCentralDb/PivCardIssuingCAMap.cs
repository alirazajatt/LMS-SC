namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PivCardIssuingCAMap")]
    public partial class PivCardIssuingCAMap
    {
        [Key]
        [Column(Order = 0)]
        public Guid CardGlobalID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CAGlobalID { get; set; }

        public virtual Card Card { get; set; }
    }
}
