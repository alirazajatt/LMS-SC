namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Viewer")]
    public partial class Viewer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Viewer()
        {
            AlarmListItemReferences = new HashSet<AlarmListItemReference>();
            AlarmListNavPanelDisplayColumns = new HashSet<AlarmListNavPanelDisplayColumn>();
            AlarmListNavPanelRules = new HashSet<AlarmListNavPanelRule>();
            AustcoIntercomViewerConfigIntercoms = new HashSet<AustcoIntercomViewerConfigIntercom>();
            CardholderSearchNavPanelDisplayColumns = new HashSet<CardholderSearchNavPanelDisplayColumn>();
            SpotMonitorViewerRules = new HashSet<SpotMonitorViewerRule>();
            ViewerOperatorGroupPairs = new HashSet<ViewerOperatorGroupPair>();
            ViewerPanels = new HashSet<ViewerPanel>();
            Doors = new HashSet<Door>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public int DisplayOrder { get; set; }

        public int NavPanelDock { get; set; }

        public double DefaultDepth { get; set; }

        [Required]
        [StringLength(200)]
        public string ViewerContract { get; set; }

        [Required]
        [StringLength(200)]
        public string NavTileContract { get; set; }

        public double ViewerWidth { get; set; }

        public double ViewerHeight { get; set; }

        public bool DisplayViewerOnEvent { get; set; }

        public bool AllowNavPanelExpansion { get; set; }

        public virtual AlarmListConfig AlarmListConfig { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlarmListItemReference> AlarmListItemReferences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlarmListNavPanelDisplayColumn> AlarmListNavPanelDisplayColumns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlarmListNavPanelRule> AlarmListNavPanelRules { get; set; }

        public virtual AustcoIntercomViewerConfig AustcoIntercomViewerConfig { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AustcoIntercomViewerConfigIntercom> AustcoIntercomViewerConfigIntercoms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CardholderSearchNavPanelDisplayColumn> CardholderSearchNavPanelDisplayColumns { get; set; }

        public virtual ControlledChallengeViewerConfig ControlledChallengeViewerConfig { get; set; }

        public virtual FTItem FTItem { get; set; }

        public virtual JacquesIntercomViewerConfig JacquesIntercomViewerConfig { get; set; }

        public virtual SpotMonitorViewer SpotMonitorViewer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpotMonitorViewerRule> SpotMonitorViewerRules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ViewerOperatorGroupPair> ViewerOperatorGroupPairs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ViewerPanel> ViewerPanels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Door> Doors { get; set; }
    }
}
