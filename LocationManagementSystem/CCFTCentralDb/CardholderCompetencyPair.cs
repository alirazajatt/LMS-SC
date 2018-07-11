namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CardholderCompetencyPair")]
    public partial class CardholderCompetencyPair
    {
        public int CardholderID { get; set; }

        public int CompetencyID { get; set; }

        [Key]
        public Guid GlobalID { get; set; }

        public int isDisabled { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public DateTime? EnableDate { get; set; }

        [StringLength(2500)]
        public string Comments { get; set; }

        public int ConflictCount { get; set; }

        public int HasLimitedCredit { get; set; }

        public int CurrentCredit { get; set; }

        public virtual Cardholder Cardholder { get; set; }

        public virtual Competency Competency { get; set; }
    }
}
