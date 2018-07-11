namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HBUSTerminalAlarmZonePair")]
    public partial class HBUSTerminalAlarmZonePair
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HBUSTerminalID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AlarmZoneID { get; set; }

        public int? ZoneIndex { get; set; }

        public virtual AlarmZone AlarmZone { get; set; }

        public virtual HBUSTerminal HBUSTerminal { get; set; }
    }
}
