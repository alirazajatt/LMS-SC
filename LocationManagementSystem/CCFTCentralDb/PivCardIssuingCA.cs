namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PivCardIssuingCA")]
    public partial class PivCardIssuingCA
    {
        [Key]
        [Column(Order = 0)]
        [MaxLength(20)]
        public byte[] SubjectKeyIdentifier { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string Name { get; set; }

        public Guid GlobalID { get; set; }

        public bool Offline { get; set; }

        [Required]
        [StringLength(260)]
        public string DisplayName { get; set; }
    }
}
