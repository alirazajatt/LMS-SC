namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DivisionInductionMaterialGroup")]
    public partial class DivisionInductionMaterialGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DivisionInductionMaterialGroup()
        {
            DivisionInductionMaterialGroupVideos = new HashSet<DivisionInductionMaterialGroupVideo>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid InductionMaterialGroupID { get; set; }

        public bool Enabled { get; set; }

        [Required]
        [StringLength(200)]
        public string Label { get; set; }

        public int DisplayOrder { get; set; }

        [Required]
        public string Description { get; set; }

        public bool AllowHostAssistance { get; set; }

        public int InductionMaterialRedisplayTimeUnit { get; set; }

        public int InductionMaterialRedisplayTime { get; set; }

        public virtual Division Division { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DivisionInductionMaterialGroupVideo> DivisionInductionMaterialGroupVideos { get; set; }
    }
}
