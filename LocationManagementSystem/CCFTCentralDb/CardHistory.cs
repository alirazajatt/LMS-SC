namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CardHistory")]
    public partial class CardHistory
    {
        [Key]
        [Column(Order = 0)]
        public DateTime OccurenceTime { get; set; }

        [Key]
        [Column(Order = 1)]
        [MaxLength(256)]
        public byte[] EncodedBinary { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FacilityCode { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IssueLevel { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ActionPerformed { get; set; }

        [MaxLength(10)]
        public byte[] CardSerialNumber { get; set; }

        public int? OperatorID { get; set; }

        public int? CardholderID { get; set; }

        public int? CardTypeID { get; set; }

        public int? CardWorkflowID { get; set; }

        public int? CardStateID { get; set; }
    }
}
