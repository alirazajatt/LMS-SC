namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VisitVisitorNotificationLog")]
    public partial class VisitVisitorNotificationLog
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CardholderID { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid NotificationID { get; set; }

        public bool IsAutomaticNotification { get; set; }

        public int CardholderNotifiedID { get; set; }

        public DateTime NotificationTime { get; set; }

        public bool CardholderNotifiedHadPDFs { get; set; }

        public virtual FTItem FTItem { get; set; }

        public virtual VisitVisitor VisitVisitor { get; set; }
    }
}
