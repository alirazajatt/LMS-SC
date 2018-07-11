namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReportDefinitionItem")]
    public partial class ReportDefinitionItem
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReportID { get; set; }

        [Required]
        [StringLength(50)]
        public string ReferenceKey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReferencedFTItemID { get; set; }

        public virtual FTItem FTItem { get; set; }

        public virtual ReportDefinition ReportDefinition { get; set; }
    }
}
