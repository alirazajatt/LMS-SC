namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PivCard")]
    public partial class PivCard
    {
        [Key]
        public Guid GlobalID { get; set; }

        [MaxLength(32)]
        public byte[] ChuidHash { get; set; }

        [MaxLength(32)]
        public byte[] CardAuthCertHash { get; set; }

        public bool Revoked { get; set; }

        public DateTime? LastCheckedTime { get; set; }

        [Required]
        [StringLength(32)]
        public string Fascn { get; set; }

        [StringLength(4)]
        public string ChuidOrgId { get; set; }

        [StringLength(9)]
        public string ChuidDuns { get; set; }

        [Required]
        [MaxLength(20)]
        public byte[] IssuerSigCertSubjectKeyIdentifier { get; set; }

        [MaxLength(2500)]
        public byte[] CardAuthCertificate { get; set; }

        [MaxLength(2500)]
        public byte[] PivAuthCertificate { get; set; }

        [MaxLength(2500)]
        public byte[] DigitalSigCertificate { get; set; }

        [MaxLength(2500)]
        public byte[] KeyMgmtCertificate { get; set; }

        public byte[] Fingerprints { get; set; }

        public byte[] IrisImages { get; set; }

        [StringLength(20)]
        public string PiEmployeeAffiliation { get; set; }

        [StringLength(10)]
        public string PiAgencyCardSN { get; set; }

        [StringLength(15)]
        public string PiIssuerIdentification { get; set; }

        [StringLength(20)]
        public string PiOrgAffiliation1 { get; set; }

        [StringLength(20)]
        public string PiOrgAffiliation2 { get; set; }

        public int? PinUsagePolicy { get; set; }

        public int Status { get; set; }

        [MaxLength(32)]
        public byte[] PivAuthCertHash { get; set; }

        public virtual Card Card { get; set; }

        public virtual PivCardIssuerCertificate PivCardIssuerCertificate { get; set; }
    }
}
