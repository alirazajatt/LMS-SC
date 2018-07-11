namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MobileDeviceChallengeReason
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DisplayIndex { get; set; }

        [Required]
        [StringLength(255)]
        public string Reason { get; set; }
    }
}
