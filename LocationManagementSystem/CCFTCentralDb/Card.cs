namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Card")]
    public partial class Card
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Card()
        {
            CredentialInvitations = new HashSet<CredentialInvitation>();
            FidoCredentials = new HashSet<FidoCredential>();
            PivCardIssuingCAMaps = new HashSet<PivCardIssuingCAMap>();
        }

        [Required]
        [StringLength(1024)]
        public string EncodedNumber { get; set; }

        public int CardTypeID { get; set; }

        public int CardholderID { get; set; }

        public int IssueLevel { get; set; }

        public int IsEnabled { get; set; }

        public DateTime? ActivationTime { get; set; }

        public DateTime? ExpiryTime { get; set; }

        public int IsTraceOn { get; set; }

        public int IsResident { get; set; }

        public int FacilityCode { get; set; }

        public DateTime? InactivityStart { get; set; }

        public DateTime? LastEncodedOrPrintedTime { get; set; }

        public int? LastEncodedOrPrintedIssueLevel { get; set; }

        [Key]
        public Guid GlobalID { get; set; }

        public int ConflictCount { get; set; }

        [Required]
        [MaxLength(256)]
        public byte[] EncodedBinary { get; set; }

        [MaxLength(10)]
        public byte[] MifareCSN { get; set; }

        [MaxLength(32)]
        public byte[] PIN { get; set; }

        public int? State { get; set; }

        public int Class { get; set; }

        public virtual Cardholder Cardholder { get; set; }

        public virtual CardType CardType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CredentialInvitation> CredentialInvitations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FidoCredential> FidoCredentials { get; set; }

        public virtual PivCard PivCard { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PivCardIssuingCAMap> PivCardIssuingCAMaps { get; set; }
    }
}
