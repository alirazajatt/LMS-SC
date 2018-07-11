namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MobileDeviceCardholderSearchType
    {
        [Key]
        public Guid SearchTypeID { get; set; }

        public int DisplayIndex { get; set; }

        public int DisplayOptions { get; set; }

        public int SearchOptions { get; set; }
    }
}
