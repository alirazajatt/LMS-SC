namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FidoAuthenticator")]
    public partial class FidoAuthenticator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AuthenticatorAttestationID { get; set; }

        [Required]
        public string Description { get; set; }

        public int AuthenticatorVersion { get; set; }

        public int AuthenticationAlgorithm { get; set; }

        public int PublicKeyAlgorithmAndEncoding { get; set; }

        public int UserVerificationDetails { get; set; }

        public int KeyProtection { get; set; }

        public bool IsSecondFactorOnly { get; set; }
    }
}
