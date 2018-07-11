namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DVRCamera")]
    public partial class DVRCamera
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DVRCamera()
        {
            SiteItemCameraPairs = new HashSet<SiteItemCameraPair>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public int? DVRTypeID { get; set; }

        [StringLength(110)]
        public string CameraUID { get; set; }

        public int? FTControllerID { get; set; }

        public virtual FTItem FTItem { get; set; }

        public virtual SiteItem SiteItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SiteItemCameraPair> SiteItemCameraPairs { get; set; }
    }
}
