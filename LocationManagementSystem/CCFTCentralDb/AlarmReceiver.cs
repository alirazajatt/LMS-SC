namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AlarmReceiver")]
    public partial class AlarmReceiver
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AlarmTransmitterID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RxIndex { get; set; }

        public bool UseRx { get; set; }

        public int IPAddress { get; set; }

        public int IPPort { get; set; }

        public int Transport { get; set; }

        [Required]
        [StringLength(16)]
        public string Acct { get; set; }

        public bool UsePoll { get; set; }

        public int PollInterval { get; set; }

        public virtual AlarmTransmitter AlarmTransmitter { get; set; }
    }
}
