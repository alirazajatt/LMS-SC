namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RemoteOverrideInfo")]
    public partial class RemoteOverrideInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemTypeID { get; set; }

        public int MsgID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VerbID { get; set; }

        public int OverrideType { get; set; }

        public int IncludeInActioninfo { get; set; }

        public int ActionInfoMenuStringID { get; set; }

        public virtual FTItemType FTItemType { get; set; }
    }
}
