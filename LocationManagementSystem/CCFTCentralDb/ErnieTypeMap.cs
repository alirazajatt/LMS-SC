namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ErnieTypeMap")]
    public partial class ErnieTypeMap
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ErnieType { get; set; }

        public int FTItemTypeID { get; set; }

        public virtual FTItemType FTItemType { get; set; }
    }
}
