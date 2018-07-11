namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SessionOperatorRouting")]
    public partial class SessionOperatorRouting
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SessionID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OperatorClubID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WorkstationRoutingID { get; set; }

        public int AccessState { get; set; }

        public virtual OperatorSession OperatorSession { get; set; }

        public virtual SessionOperatorClub SessionOperatorClub { get; set; }

        public virtual WorkstationRouting WorkstationRouting { get; set; }
    }
}
