namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DVRType")]
    public partial class DVRType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        [Required]
        [StringLength(255)]
        public string HostName { get; set; }

        [Required]
        [StringLength(110)]
        public string UserName { get; set; }

        [Required]
        [StringLength(110)]
        public string Password { get; set; }

        public Guid StoredViewerCLSID { get; set; }

        public Guid LiveViewerCLSID { get; set; }

        public int CreateNewWindows { get; set; }

        public virtual FTItem FTItem { get; set; }
    }
}
