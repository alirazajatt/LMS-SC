namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HBUSTerminalMimicItem")]
    public partial class HBUSTerminalMimicItem
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HBUSTerminalID { get; set; }

        public int? FTItemID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemIndex { get; set; }

        [Required]
        [StringLength(110)]
        public string ItemLabel { get; set; }

        public virtual HBUSTerminal HBUSTerminal { get; set; }
    }
}
