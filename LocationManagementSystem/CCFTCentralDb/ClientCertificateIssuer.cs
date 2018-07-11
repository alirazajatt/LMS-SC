namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientCertificateIssuer")]
    public partial class ClientCertificateIssuer
    {
        [Key]
        public int IssuerID { get; set; }

        [Required]
        [MaxLength(8000)]
        public byte[] Certificate { get; set; }
    }
}
