namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HBUSReader
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public int DoubleCardOverrideMode { get; set; }

        public int UseMifareCardSerialNumber { get; set; }

        public int EnhancedMifare { get; set; }

        public int Volume { get; set; }

        public int Brightness { get; set; }

        public int PinIsUserCode { get; set; }

        public int SurfaceIsMetal { get; set; }

        public bool CanReadMifare { get; set; }

        public bool CanRead125 { get; set; }

        public bool HasSam { get; set; }

        public bool HasDualBuzzer { get; set; }

        public int CardTechEnforcement { get; set; }

        public bool RequireProximityCheck { get; set; }

        public int CardDataRate { get; set; }

        public int PIVAuthMode { get; set; }

        public virtual SiteItem SiteItem { get; set; }
    }
}
