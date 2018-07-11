namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DetectedDevice
    {
        public int ControllerID { get; set; }

        [Key]
        [StringLength(10)]
        public string DeviceSerial { get; set; }

        public Guid FTItemClassID { get; set; }

        public int Bus { get; set; }

        public int Port { get; set; }

        public int ErnieType { get; set; }

        public virtual FTItem FTItem { get; set; }
    }
}
