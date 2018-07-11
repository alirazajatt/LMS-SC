namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobileDevice")]
    public partial class MobileDevice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public int? CertificateIssuerID { get; set; }

        [MaxLength(32)]
        public byte[] PublicKeyHash { get; set; }

        public int LockoutMode { get; set; }

        public int LockoutTime { get; set; }

        public bool AllowBiometricUnlock { get; set; }

        public bool IsMobileReader { get; set; }

        public virtual WorkstationBase WorkstationBase { get; set; }

        public virtual MobileDeviceEnrolment MobileDeviceEnrolment { get; set; }
    }
}
