namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DivisionInductionMaterialQuestion")]
    public partial class DivisionInductionMaterialQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DivisionInductionMaterialQuestion()
        {
            DivisionInductionMaterialAnswers = new HashSet<DivisionInductionMaterialAnswer>();
        }

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

        public int DisplayOrder { get; set; }

        [Required]
        public string QuestionText { get; set; }

        public Guid CorrectAnswerID { get; set; }

        public int? ReviewStartTime { get; set; }

        public int? ReviewEndTime { get; set; }

        public virtual DivisionInductionMaterial DivisionInductionMaterial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DivisionInductionMaterialAnswer> DivisionInductionMaterialAnswers { get; set; }
    }
}
