namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GBusURI")]
    public partial class GBusURI
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public bool? OLMEnable { get; set; }

        public int OLMNumOfDoors { get; set; }

        public int OLMUCF { get; set; }

        public int OLMFacilityCode { get; set; }

        public int OLMDoor1PushButton { get; set; }

        public int OLMDoor2PushButton { get; set; }

        public int GbusUriType { get; set; }

        public virtual SiteItem SiteItem { get; set; }
    }
}
