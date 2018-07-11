namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FidoCredential")]
    public partial class FidoCredential
    {
        [Key]
        public Guid GlobalID { get; set; }

        public Guid CardID { get; set; }

        public int AuthenticatorAttestationID { get; set; }

        public int AuthenticatorVersion { get; set; }

        [Required]
        [MaxLength(2048)]
        public byte[] KeyID { get; set; }

        [Required]
        public byte[] PublicKey { get; set; }

        public int PublicKeyFormat { get; set; }

        public int RegistrationCounter { get; set; }

        public int SignatureCounter { get; set; }

        public virtual Card Card { get; set; }
    }
}
