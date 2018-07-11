namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SchlageDevice")]
    public partial class SchlageDevice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public int RS485Address { get; set; }

        public int LowDoor { get; set; }

        public int HighDoor { get; set; }

        public int UnlockDelay { get; set; }

        public int AltUnlockDelay { get; set; }

        public int DOTLWarnTime { get; set; }

        public int DOTLAlarmTime { get; set; }

        public int CanOpen { get; set; }

        public int WOR { get; set; }

        public int PinIsUserCode { get; set; }

        public int CardSwipeTimeout { get; set; }

        public int PinEntryTimeout { get; set; }

        public int DoubleCardOverrideMode { get; set; }

        public virtual FieldDevice FieldDevice { get; set; }
    }
}
