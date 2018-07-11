namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AlarmDetailsTileField")]
    public partial class AlarmDetailsTileField
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string BrowseName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TileID { get; set; }

        public virtual ViewerPanelTile ViewerPanelTile { get; set; }
    }
}
