namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AustcoIntercomViewerConfig")]
    public partial class AustcoIntercomViewerConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public int IntercomConfigType { get; set; }

        public int? DefaultPanelID { get; set; }

        public virtual Viewer Viewer { get; set; }

        public virtual ViewerPanel ViewerPanel { get; set; }
    }
}
