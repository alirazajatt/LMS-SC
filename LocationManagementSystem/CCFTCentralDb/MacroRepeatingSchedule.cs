namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MacroRepeatingSchedule")]
    public partial class MacroRepeatingSchedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public DateTime ScheduleFrom { get; set; }

        public DateTime? ScheduleUntil { get; set; }

        public int ScheduleRepeatCount { get; set; }

        public int ScheduleRepeatUnit { get; set; }

        public int ScheduleWeekdayMask { get; set; }

        public int? OperatorID { get; set; }

        public int? WorkstationID { get; set; }

        public virtual Macro Macro { get; set; }
    }
}
