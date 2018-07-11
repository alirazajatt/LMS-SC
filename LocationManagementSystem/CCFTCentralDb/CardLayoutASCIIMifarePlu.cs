namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CardLayoutASCIIMifarePlu
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

        public int SectorNumber { get; set; }

        [Required]
        [MaxLength(6)]
        public byte[] ReadKey { get; set; }

        [Required]
        [MaxLength(6)]
        public byte[] WriteKey { get; set; }

        public bool WriteMad { get; set; }

        public int MadCode { get; set; }

        public bool EncodeAsASCII { get; set; }

        [Required]
        [MaxLength(16)]
        public byte[] ReadKeyPlus { get; set; }

        [Required]
        [MaxLength(16)]
        public byte[] WriteKeyPlus { get; set; }

        public virtual CardLayoutObject CardLayoutObject { get; set; }
    }
}
