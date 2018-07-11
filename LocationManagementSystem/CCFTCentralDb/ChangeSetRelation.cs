namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChangeSetRelation")]
    public partial class ChangeSetRelation
    {
        [Key]
        [Column(Order = 0)]
        public Guid ChangeSetID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid FTItemID { get; set; }

        public virtual ChangeSet ChangeSet { get; set; }
    }
}
