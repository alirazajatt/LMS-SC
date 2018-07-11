namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReportDefinitionSchedule")]
    public partial class ReportDefinitionSchedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReportID { get; set; }

        public DateTime ScheduleFrom { get; set; }

        public DateTime? ScheduleUntil { get; set; }

        public int ScheduleRepeatCount { get; set; }

        public int ScheduleRepeatUnit { get; set; }

        public int ScheduleWeekdayMask { get; set; }

        public virtual ReportDefinition ReportDefinition { get; set; }
    }
}
