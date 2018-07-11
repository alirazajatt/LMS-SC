namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CardholderFingerprint")]
    public partial class CardholderFingerprint
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public int BiometricID { get; set; }

        public int FingerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FingerType { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FingerSeqNo { get; set; }

        public byte[] FingerprintMinutiae { get; set; }

        public int SagemReaderDatabaseID { get; set; }

        public int Quality { get; set; }

        public int MatchingScore { get; set; }

        public byte[] FingerVeinMinutiae { get; set; }

        public virtual Cardholder Cardholder { get; set; }
    }
}
