namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SitePlanGraphic")]
    public partial class SitePlanGraphic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SitePlanGraphic()
        {
            SitePlanGraphicItems = new HashSet<SitePlanGraphicItem>();
            SitePlanGraphicPoints = new HashSet<SitePlanGraphicPoint>();
        }

        public int ID { get; set; }

        public int SitePlanID { get; set; }

        public int? SiteItemID { get; set; }

        public int? SitePlanLinkID { get; set; }

        public int GraphicType { get; set; }

        public int Visible { get; set; }

        public int CoreColour { get; set; }

        public int CoreThickness { get; set; }

        public int Transparency { get; set; }

        [Required]
        [StringLength(64)]
        public string FontFamily { get; set; }

        public int FontStyle { get; set; }

        public float FontSize { get; set; }

        public int Alignment { get; set; }

        [Required]
        [StringLength(2000)]
        public string TextContent { get; set; }

        public int ClickExecute { get; set; }

        public Guid GlobalID { get; set; }

        public int DisplayOrder { get; set; }

        public int IgnoreLocation { get; set; }

        public int IgnoreLocationValue { get; set; }

        public int ValueType { get; set; }

        public int ColourByThresholds { get; set; }

        public int FontColour { get; set; }

        public virtual SiteItem SiteItem { get; set; }

        public virtual SitePlan SitePlan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SitePlanGraphicItem> SitePlanGraphicItems { get; set; }

        public virtual SitePlanLink SitePlanLink { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SitePlanGraphicPoint> SitePlanGraphicPoints { get; set; }
    }
}
