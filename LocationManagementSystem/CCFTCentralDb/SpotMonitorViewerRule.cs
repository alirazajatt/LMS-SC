namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SpotMonitorViewerRule")]
    public partial class SpotMonitorViewerRule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SpotMonitorViewerRule()
        {
            SpotMonitorViewerRuleDivisionItemTypes = new HashSet<SpotMonitorViewerRuleDivisionItemType>();
            FTItems = new HashSet<FTItem>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RuleID { get; set; }

        public int AlarmPriority { get; set; }

        public int RulePriority { get; set; }

        public bool AppliesToMultipleAlarms { get; set; }

        public Guid PanelID { get; set; }

        public int RuleSourceType { get; set; }

        public virtual Viewer Viewer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpotMonitorViewerRuleDivisionItemType> SpotMonitorViewerRuleDivisionItemTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FTItem> FTItems { get; set; }
    }
}
