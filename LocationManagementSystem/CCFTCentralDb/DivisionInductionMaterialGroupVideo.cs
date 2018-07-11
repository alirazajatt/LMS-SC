namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DivisionInductionMaterialGroupVideo")]
    public partial class DivisionInductionMaterialGroupVideo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid InductionMaterialGroupID { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid InductionMaterialID { get; set; }

        public int DisplayOrder { get; set; }

        public virtual DivisionInductionMaterialGroup DivisionInductionMaterialGroup { get; set; }
    }
}
