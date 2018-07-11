namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HBUSTerminalOutputPair")]
    public partial class HBUSTerminalOutputPair
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HBUSTerminalID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OutputID { get; set; }

        [Required]
        [StringLength(200)]
        public string Label { get; set; }

        public bool OnOptionsMenu { get; set; }

        public int OutputIndex { get; set; }

        public virtual HBUSTerminal HBUSTerminal { get; set; }

        public virtual Output Output { get; set; }
    }
}
