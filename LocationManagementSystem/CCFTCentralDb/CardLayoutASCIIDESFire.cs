namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CardLayoutASCIIDESFire")]
    public partial class CardLayoutASCIIDESFire
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SideIndex { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ObjectIndex { get; set; }

        public int AppID { get; set; }

        public bool EncodeAsASCII { get; set; }

        public int KeyType { get; set; }

        [Required]
        [MaxLength(24)]
        public byte[] TheKey { get; set; }

        public bool AuthRequiredForRead { get; set; }

        public virtual CardLayoutObject CardLayoutObject { get; set; }
    }
}
