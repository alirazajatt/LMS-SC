namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CardholderDetailsTile")]
    public partial class CardholderDetailsTile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CardholderDetailsTile()
        {
            CardholderDetailsTileFields = new HashSet<CardholderDetailsTileField>();
        }

        public bool AllPersonalData { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TileID { get; set; }

        public virtual ViewerPanelTile ViewerPanelTile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CardholderDetailsTileField> CardholderDetailsTileFields { get; set; }
    }
}
