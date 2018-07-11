namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DivisionInductionMaterial")]
    public partial class DivisionInductionMaterial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DivisionInductionMaterial()
        {
            DivisionInductionMaterialQuestions = new HashSet<DivisionInductionMaterialQuestion>();
            Competencies = new HashSet<Competency>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid InductionMaterialID { get; set; }

        [Required]
        [StringLength(200)]
        public string Label { get; set; }

        [Required]
        [StringLength(260)]
        public string Content { get; set; }

        public DateTime ModificationDate { get; set; }

        public virtual Division Division { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DivisionInductionMaterialQuestion> DivisionInductionMaterialQuestions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Competency> Competencies { get; set; }
    }
}
