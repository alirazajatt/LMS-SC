namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobileDeviceEnrolment")]
    public partial class MobileDeviceEnrolment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        [Required]
        [MaxLength(32)]
        public byte[] EnrolmentKey { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ExpiryTime { get; set; }

        public virtual MobileDevice MobileDevice { get; set; }
    }
}
