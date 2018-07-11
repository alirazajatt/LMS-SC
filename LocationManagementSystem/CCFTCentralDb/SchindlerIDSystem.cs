namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SchindlerIDSystem")]
    public partial class SchindlerIDSystem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        [StringLength(255)]
        public string HostName { get; set; }

        public int Port { get; set; }

        public int BadgeNumber1Pref { get; set; }

        public int BadgeNumber2Pref { get; set; }

        public int BadgeNumber3Pref { get; set; }

        public int BadgeNumberLength { get; set; }

        public int BadgeType { get; set; }

        public virtual SiteItem SiteItem { get; set; }
    }
}
