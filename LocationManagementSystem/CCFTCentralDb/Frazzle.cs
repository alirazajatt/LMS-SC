namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Frazzle")]
    public partial class Frazzle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Frazzle()
        {
            HBUSTerminalFenceControllerPairs = new HashSet<HBUSTerminalFenceControllerPair>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public int TamperDisabled { get; set; }

        public float PulseInterval { get; set; }

        public int PowerLevel { get; set; }

        public int LowFeelPowerLevel { get; set; }

        public int SynchronisationSource { get; set; }

        public int SyncMicroDelay { get; set; }

        public float LowBatteryLevel { get; set; }

        public int GoSlowOnMainsFail { get; set; }

        public int GoSlowMainsFailDelay { get; set; }

        public float GoSlowBatteryLevel { get; set; }

        public float StopBatteryLevel { get; set; }

        public float TestBatteryLevel { get; set; }

        public bool DataLogBatteryVoltageIntervalEnabled { get; set; }

        public bool DataLogBatteryVoltageChangeEnabled { get; set; }

        public int DataLogBatteryVoltageInterval { get; set; }

        public float DataLogBatteryVoltageChange { get; set; }

        public bool DataLogTemperatureIntervalEnabled { get; set; }

        public bool DataLogTemperatureChangeEnabled { get; set; }

        public int DataLogTemperatureInterval { get; set; }

        public float DataLogTemperatureChange { get; set; }

        public int? HighTemperatureOutputID { get; set; }

        public float HighTemperatureLevel { get; set; }

        public float VeryHighTemperatureLevel { get; set; }

        public float CriticalTemperatureLevel { get; set; }

        public int BatterySaveMode { get; set; }

        public int ErnieType { get; set; }

        public bool EnableServiceMode { get; set; }

        public bool EnableInternalBatteryBypass { get; set; }

        public bool HVPlusEnabled { get; set; }

        public virtual SiteItem SiteItem { get; set; }

        public virtual SiteItem SiteItem1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HBUSTerminalFenceControllerPair> HBUSTerminalFenceControllerPairs { get; set; }
    }
}
