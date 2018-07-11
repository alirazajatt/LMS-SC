namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ChildParentHBusDevice
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ControllerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string ChildDeviceSerial { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string ParentDeviceSerial { get; set; }
    }
}
