namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CardholderInductionMaterialRead")]
    public partial class CardholderInductionMaterialRead
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DivisionId { get; set; }

        public DateTime InductionMaterialRead { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid InductionMaterialGroupID { get; set; }

        public virtual Cardholder Cardholder { get; set; }

        public virtual Division Division { get; set; }
    }
}
