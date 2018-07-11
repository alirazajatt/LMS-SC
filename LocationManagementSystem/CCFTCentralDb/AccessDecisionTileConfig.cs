namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccessDecisionTileConfig")]
    public partial class AccessDecisionTileConfig
    {
        public int AccessDecisionConfigType { get; set; }

        public int? SpecificDoorItemID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TileID { get; set; }

        public virtual FTItem FTItem { get; set; }

        public virtual ViewerPanelTile ViewerPanelTile { get; set; }
    }
}
