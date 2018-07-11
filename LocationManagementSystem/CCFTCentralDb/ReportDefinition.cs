namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReportDefinition")]
    public partial class ReportDefinition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReportDefinition()
        {
            ReportDefinitionItems = new HashSet<ReportDefinitionItem>();
            ReportDefinitionScheduleTimes = new HashSet<ReportDefinitionScheduleTime>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        [Required]
        public string Definition { get; set; }

        [Required]
        [StringLength(200)]
        public string Contract { get; set; }

        [Required]
        [StringLength(200)]
        public string QueryContract { get; set; }

        [Required]
        [StringLength(200)]
        public string RenderContract { get; set; }

        public string Printer { get; set; }

        public string FileName { get; set; }

        [StringLength(50)]
        public string FileFormat { get; set; }

        public string TimeZone { get; set; }

        [StringLength(50)]
        public string Language { get; set; }

        public Guid? LogoGUID { get; set; }

        public Guid? DisclaimerGUID { get; set; }

        public virtual FTItem FTItem { get; set; }

        public virtual SharedBinary SharedBinary { get; set; }

        public virtual SharedBinary SharedBinary1 { get; set; }

        public virtual ReportDefinitionEmailRecipient ReportDefinitionEmailRecipient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportDefinitionItem> ReportDefinitionItems { get; set; }

        public virtual ReportDefinitionSchedule ReportDefinitionSchedule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportDefinitionScheduleTime> ReportDefinitionScheduleTimes { get; set; }
    }
}
