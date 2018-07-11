namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewerOperatorGroupPair")]
    public partial class ViewerOperatorGroupPair
    {
        public int ViewerID { get; set; }

        public int OperatorGroupID { get; set; }

        [Key]
        public Guid GlobalID { get; set; }

        public virtual OperatorClub OperatorClub { get; set; }

        public virtual Viewer Viewer { get; set; }
    }
}
