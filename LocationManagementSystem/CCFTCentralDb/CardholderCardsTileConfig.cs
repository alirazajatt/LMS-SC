namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CardholderCardsTileConfig")]
    public partial class CardholderCardsTileConfig
    {
        public bool ShowCSNColumn { get; set; }

        public bool ShowCSNInHexadecimal { get; set; }

        public bool ReverseCSNBytes { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TileID { get; set; }

        public virtual ViewerPanelTile ViewerPanelTile { get; set; }
    }
}
