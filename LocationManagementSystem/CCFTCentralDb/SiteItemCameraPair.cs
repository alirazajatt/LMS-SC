namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SiteItemCameraPair")]
    public partial class SiteItemCameraPair
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SiteItemID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CameraID { get; set; }

        public int SortOrder { get; set; }

        public Guid GlobalID { get; set; }

        public virtual DVRCamera DVRCamera { get; set; }

        public virtual SiteItem SiteItem { get; set; }
    }
}
