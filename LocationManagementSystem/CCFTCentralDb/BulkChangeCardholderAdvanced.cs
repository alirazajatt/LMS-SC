namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BulkChangeCardholderAdvanced")]
    public partial class BulkChangeCardholderAdvanced
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public string SelectionCriteria { get; set; }

        public bool RunInCardholderViewer { get; set; }

        public virtual FTItem FTItem { get; set; }
    }
}
