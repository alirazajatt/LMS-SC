namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PivCardTrustedRootCert")]
    public partial class PivCardTrustedRootCert
    {
        [Key]
        [StringLength(256)]
        public string DisplayName { get; set; }
    }
}
