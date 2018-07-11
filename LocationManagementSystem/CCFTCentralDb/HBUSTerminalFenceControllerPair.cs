namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HBUSTerminalFenceControllerPair")]
    public partial class HBUSTerminalFenceControllerPair
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HBUSTerminalID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FenceControllerID { get; set; }

        public int ControllerIndex { get; set; }

        public virtual Frazzle Frazzle { get; set; }

        public virtual HBUSTerminal HBUSTerminal { get; set; }
    }
}
