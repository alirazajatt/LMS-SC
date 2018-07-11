namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReportDefinitionScheduleTime")]
    public partial class ReportDefinitionScheduleTime
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReportID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime ScheduledTime { get; set; }

        public virtual ReportDefinition ReportDefinition { get; set; }
    }
}
