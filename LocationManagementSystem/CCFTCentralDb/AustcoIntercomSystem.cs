namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AustcoIntercomSystem")]
    public partial class AustcoIntercomSystem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        [Required]
        [StringLength(255)]
        public string HostName { get; set; }

        public int IPAddress { get; set; }

        public int IPPort { get; set; }

        public int Countdown { get; set; }
    }
}
