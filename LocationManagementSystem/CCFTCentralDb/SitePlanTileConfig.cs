namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SitePlanTileConfig")]
    public partial class SitePlanTileConfig
    {
        public int SiteplanConfigType { get; set; }

        public int? SpecificSitePlanItemID { get; set; }

        public bool SitePlanNavigationDisabled { get; set; }

        public int ShowNavigationBar { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TileID { get; set; }

        public virtual ViewerPanelTile ViewerPanelTile { get; set; }
    }
}
