namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HBUSTerminal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HBUSTerminal()
        {
            HBUSTerminalAlarmZonePairs = new HashSet<HBUSTerminalAlarmZonePair>();
            HBUSTerminalFenceControllerPairs = new HashSet<HBUSTerminalFenceControllerPair>();
            HBUSTerminalMimicItems = new HashSet<HBUSTerminalMimicItem>();
            HBUSTerminalOutputPairs = new HashSet<HBUSTerminalOutputPair>();
            Inputs = new HashSet<Input>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public int InactivityTimeout { get; set; }

        public int PinsTimeout { get; set; }

        public int DisplayAlarmZoneID { get; set; }

        public bool DisableTamper { get; set; }

        public bool DisplayAlarmsInSystem { get; set; }

        public int LogonCredential1 { get; set; }

        public int LogonCredential2 { get; set; }

        public bool AlarmsWarningBeep { get; set; }

        public bool ShowDisplayAlarmZoneStatus { get; set; }

        public bool AlarmListUseDefaults { get; set; }

        public bool AcknowledgeAlarmsOnDisarm { get; set; }

        public int AlarmListMinPriority { get; set; }

        public bool ArmingUseDefaults { get; set; }

        [StringLength(60)]
        public string ArmingFailedMessage { get; set; }

        public bool ShowMimicOnIdle { get; set; }

        public bool ViewAckdAlarmsOnDisarm { get; set; }

        public bool ScreenAlwaysOn { get; set; }

        public bool ShowDisplayAlarmZoneEntryDelay { get; set; }

        public bool ShowDisplayAlarmZoneExitDelay { get; set; }

        public bool DisplayIsolatedInputs { get; set; }

        public bool IdleImageUseDefaults { get; set; }

        public bool ShowIdleImage { get; set; }

        [Required]
        [StringLength(200)]
        public string ActionsScreenName { get; set; }

        public int FailedLogonAttempt { get; set; }

        public int SubsequentFailedLogonAttempt { get; set; }

        public bool EnableLockout { get; set; }

        public bool RepeatedLogonUseDefaults { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HBUSTerminalAlarmZonePair> HBUSTerminalAlarmZonePairs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HBUSTerminalFenceControllerPair> HBUSTerminalFenceControllerPairs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HBUSTerminalMimicItem> HBUSTerminalMimicItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HBUSTerminalOutputPair> HBUSTerminalOutputPairs { get; set; }

        public virtual SiteItem SiteItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Input> Inputs { get; set; }
    }
}
