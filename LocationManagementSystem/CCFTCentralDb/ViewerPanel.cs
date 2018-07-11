namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewerPanel")]
    public partial class ViewerPanel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ViewerPanel()
        {
            AlarmListNavPanelRules = new HashSet<AlarmListNavPanelRule>();
            AustcoIntercomViewerConfigs = new HashSet<AustcoIntercomViewerConfig>();
            AustcoIntercomViewerConfigPanelIntercoms = new HashSet<AustcoIntercomViewerConfigPanelIntercom>();
            ControlledChallengeViewerConfigs = new HashSet<ControlledChallengeViewerConfig>();
            ControlledChallengeViewerConfigPanelDoors = new HashSet<ControlledChallengeViewerConfigPanelDoor>();
            JacquesIntercomViewerConfigs = new HashSet<JacquesIntercomViewerConfig>();
            JacquesIntercomViewerConfigPanelIntercoms = new HashSet<JacquesIntercomViewerConfigPanelIntercom>();
            ViewerPanelTiles = new HashSet<ViewerPanelTile>();
        }

        [Key]
        public int PanelID { get; set; }

        public int FTItemID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Contract { get; set; }

        public Guid GlobalID { get; set; }

        public int DisplayOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlarmListNavPanelRule> AlarmListNavPanelRules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AustcoIntercomViewerConfig> AustcoIntercomViewerConfigs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AustcoIntercomViewerConfigPanelIntercom> AustcoIntercomViewerConfigPanelIntercoms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ControlledChallengeViewerConfig> ControlledChallengeViewerConfigs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ControlledChallengeViewerConfigPanelDoor> ControlledChallengeViewerConfigPanelDoors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JacquesIntercomViewerConfig> JacquesIntercomViewerConfigs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JacquesIntercomViewerConfigPanelIntercom> JacquesIntercomViewerConfigPanelIntercoms { get; set; }

        public virtual Viewer Viewer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ViewerPanelTile> ViewerPanelTiles { get; set; }
    }
}
