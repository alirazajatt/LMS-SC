namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CardholderFingerprintsTile")]
    public partial class CardholderFingerprintsTile
    {
        public bool ShowDuressFingerprints { get; set; }

        public bool ShowReaderDatabaseID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TileID { get; set; }

        public virtual ViewerPanelTile ViewerPanelTile { get; set; }
    }
}
