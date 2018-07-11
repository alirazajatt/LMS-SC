namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DVRCameraTileConfig")]
    public partial class DVRCameraTileConfig
    {
        public short CameraConfigType { get; set; }

        public int SpecificCameraItemID { get; set; }

        public int EventSourceLiveCameraNumber { get; set; }

        public int ShowCameraControls { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TileID { get; set; }

        public virtual ViewerPanelTile ViewerPanelTile { get; set; }
    }
}
