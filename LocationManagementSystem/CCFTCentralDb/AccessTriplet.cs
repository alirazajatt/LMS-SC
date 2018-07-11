namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccessTriplet")]
    public partial class AccessTriplet
    {
        public int ClubID { get; set; }

        public int AccessZoneID { get; set; }

        public int ScheduleID { get; set; }

        public Guid ID { get; set; }

        public virtual SiteItem SiteItem { get; set; }

        public virtual Club Club { get; set; }

        public virtual FTItem FTItem { get; set; }
    }
}
