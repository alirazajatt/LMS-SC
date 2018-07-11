namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PromptEntry")]
    public partial class PromptEntry
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PromptID { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte Row { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte Col { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte Type { get; set; }

        [Key]
        [Column(Order = 4)]
        public byte Parameter { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(127)]
        public string PromptString { get; set; }
    }
}
