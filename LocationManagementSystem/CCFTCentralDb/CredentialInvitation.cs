namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CredentialInvitation")]
    public partial class CredentialInvitation
    {
        [Key]
        public int InvitationID { get; set; }

        public Guid CardID { get; set; }

        [Required]
        [StringLength(254)]
        public string Email { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Expiry { get; set; }

        [StringLength(100)]
        public string InvitationCode { get; set; }

        public int Status { get; set; }

        public virtual Card Card { get; set; }
    }
}
