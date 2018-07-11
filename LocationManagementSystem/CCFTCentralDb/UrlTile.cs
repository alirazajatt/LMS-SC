namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UrlTile")]
    public partial class UrlTile
    {
        public short ConfigType { get; set; }

        public string SpecificUrl { get; set; }

        public Guid? UrlPdfID { get; set; }

        public Guid? SpecificDoorGlobalId { get; set; }

        public int NavigationOption { get; set; }

        public bool AutoRefreshEnabled { get; set; }

        public int AutoRefreshValue { get; set; }

        public short AutoRefreshUnit { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TileID { get; set; }

        public virtual ViewerPanelTile ViewerPanelTile { get; set; }
    }
}
