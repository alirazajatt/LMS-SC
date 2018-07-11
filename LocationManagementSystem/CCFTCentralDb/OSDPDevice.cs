namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OSDPDevice")]
    public partial class OSDPDevice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public int DeviceAddress { get; set; }

        public int DoubleCardOverrideMode { get; set; }

        public int PinIsUserCode { get; set; }

        public virtual FieldDevice FieldDevice { get; set; }
    }
}
