namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DivisionInductionMaterialAnswer")]
    public partial class DivisionInductionMaterialAnswer
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid InductionMaterialID { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid InductionMaterialQuestionID { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid InductionMaterialAnswerID { get; set; }

        public int DisplayOrder { get; set; }

        [Required]
        public string AnswerText { get; set; }

        public virtual DivisionInductionMaterialQuestion DivisionInductionMaterialQuestion { get; set; }
    }
}
