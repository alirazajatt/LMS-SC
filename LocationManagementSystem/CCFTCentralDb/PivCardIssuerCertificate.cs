namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PivCardIssuerCertificate")]
    public partial class PivCardIssuerCertificate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PivCardIssuerCertificate()
        {
            PivCards = new HashSet<PivCard>();
        }

        [Key]
        [MaxLength(20)]
        public byte[] SubjectKeyIdentifier { get; set; }

        [Required]
        [MaxLength(2500)]
        public byte[] Certificate { get; set; }

        [Required]
        [StringLength(250)]
        public string SubjectName { get; set; }

        public bool IgnoreExpiry { get; set; }

        public DateTime ExpiryTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PivCard> PivCards { get; set; }
    }
}
