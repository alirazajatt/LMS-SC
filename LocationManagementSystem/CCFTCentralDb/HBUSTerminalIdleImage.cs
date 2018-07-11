namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HBUSTerminalIdleImage")]
    public partial class HBUSTerminalIdleImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HBUSTerminalID { get; set; }

        public Guid ImageID { get; set; }

        [Required]
        public string ImageName { get; set; }

        public virtual SiteItem SiteItem { get; set; }
    }
}
