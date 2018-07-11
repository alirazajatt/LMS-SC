namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HBUSTautWireSensor
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WireNumber { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string SerialNumber { get; set; }

        public int PhysicalAddress { get; set; }

        [StringLength(12)]
        public string SoftwareVersion { get; set; }

        public virtual HBUSDevice HBUSDevice { get; set; }
    }
}
