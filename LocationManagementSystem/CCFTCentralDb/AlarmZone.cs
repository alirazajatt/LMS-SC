namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AlarmZone")]
    public partial class AlarmZone
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AlarmZone()
        {
            AlarmListNavPanelRules = new HashSet<AlarmListNavPanelRule>();
            AlarmZoneRelations = new HashSet<AlarmZoneRelation>();
            AlarmZoneRelations1 = new HashSet<AlarmZoneRelation>();
            EventGroupZoneActionPlans = new HashSet<EventGroupZoneActionPlan>();
            HBUSTerminalAlarmZonePairs = new HashSet<HBUSTerminalAlarmZonePair>();
            SiteItems = new HashSet<SiteItem>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        [Required]
        [StringLength(3)]
        public string DiallingGG { get; set; }

        [StringLength(7)]
        public string DiallingACCT { get; set; }

        public int AlarmDiallerID { get; set; }

        public int? PrearmTimeout { get; set; }

        public bool ResetConfAlarms { get; set; }

        public bool DisableCAOnAccess { get; set; }

        public bool FailArmUnack { get; set; }

        public bool PeriodicTestEnabled { get; set; }

        public int TestPostponeDays { get; set; }

        public int TestTimeout { get; set; }

        public int HVLFStateWhenKeyswitchClosed { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlarmListNavPanelRule> AlarmListNavPanelRules { get; set; }

        public virtual SiteItem SiteItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlarmZoneRelation> AlarmZoneRelations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlarmZoneRelation> AlarmZoneRelations1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventGroupZoneActionPlan> EventGroupZoneActionPlans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HBUSTerminalAlarmZonePair> HBUSTerminalAlarmZonePairs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SiteItem> SiteItems { get; set; }
    }
}
