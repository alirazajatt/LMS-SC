namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TagBoardTile")]
    public partial class TagBoardTile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TagBoardTile()
        {
            TagboardFTItems = new HashSet<TagboardFTItem>();
            FTItems = new HashSet<FTItem>();
        }

        public int ConfigType { get; set; }

        [Required]
        [StringLength(260)]
        public string BackupFileName { get; set; }

        [Required]
        [StringLength(260)]
        public string BackupFolderName { get; set; }

        public int AllowChangingZones { get; set; }

        public int IgnoreLocationInformation { get; set; }

        [Required]
        [StringLength(20)]
        public string IgnoreLocationInformationValue { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TileID { get; set; }

        public string Columns { get; set; }

        public string SelectionCriteria { get; set; }

        public int DisplayAllCardholders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TagboardFTItem> TagboardFTItems { get; set; }

        public virtual ViewerPanelTile ViewerPanelTile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FTItem> FTItems { get; set; }
    }
}
