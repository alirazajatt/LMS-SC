namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarParkGroup")]
    public partial class CarParkGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public int FreeParkingDuration { get; set; }

        public int ChargedParkingDuration { get; set; }

        public int CreditsToDeduct { get; set; }

        public int CreditWarnThreshold { get; set; }

        public int CompetencyUpdateOption { get; set; }

        public virtual SiteItem SiteItem { get; set; }
    }
}
