namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewerPanelTile")]
    public partial class ViewerPanelTile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ViewerPanelTile()
        {
            AlarmDetailsTileFields = new HashSet<AlarmDetailsTileField>();
            ViewerPanelTileItemRelationships = new HashSet<ViewerPanelTileItemRelationship>();
        }

        public int FTItemID { get; set; }

        public int PanelID { get; set; }

        [Key]
        public int TileID { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(200)]
        public string Contract { get; set; }

        public Guid GlobalID { get; set; }

        public double Left { get; set; }

        public double Top { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public int ConfigType { get; set; }

        public int ShowHeader { get; set; }

        public virtual AccessDecisionTileConfig AccessDecisionTileConfig { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlarmDetailsTileField> AlarmDetailsTileFields { get; set; }

        public virtual CardholderCardsTileConfig CardholderCardsTileConfig { get; set; }

        public virtual CardholderDetailsTile CardholderDetailsTile { get; set; }

        public virtual CardholderFingerprintsTile CardholderFingerprintsTile { get; set; }

        public virtual CardholderImagesTile CardholderImagesTile { get; set; }

        public virtual DVRCameraTileConfig DVRCameraTileConfig { get; set; }

        public virtual EventTrailTile EventTrailTile { get; set; }

        public virtual GuardTourTileConfig GuardTourTileConfig { get; set; }

        public virtual SitePlanTileConfig SitePlanTileConfig { get; set; }

        public virtual StatusTile StatusTile { get; set; }

        public virtual TagBoardTile TagBoardTile { get; set; }

        public virtual UrlTile UrlTile { get; set; }

        public virtual ViewerPanel ViewerPanel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ViewerPanelTileItemRelationship> ViewerPanelTileItemRelationships { get; set; }
    }
}
