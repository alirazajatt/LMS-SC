namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HBUSIOBoard
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public bool DisableTamper { get; set; }

        public int ErnieType { get; set; }

        public bool DisableRearTamper { get; set; }

        public virtual SiteItem SiteItem { get; set; }
    }
}
