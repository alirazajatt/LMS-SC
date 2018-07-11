namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HBUSAlarmsTerminal")]
    public partial class HBUSAlarmsTerminal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public int Volume { get; set; }

        public int Brightness { get; set; }

        public virtual SiteItem SiteItem { get; set; }
    }
}
