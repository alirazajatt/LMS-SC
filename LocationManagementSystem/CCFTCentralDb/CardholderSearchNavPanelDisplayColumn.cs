namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CardholderSearchNavPanelDisplayColumn")]
    public partial class CardholderSearchNavPanelDisplayColumn
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DisplayOrder { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(100)]
        public string FieldBrowseName { get; set; }

        public int? PersonalDataFieldID { get; set; }

        public int Width { get; set; }

        public virtual PersonalDataField PersonalDataField { get; set; }

        public virtual Viewer Viewer { get; set; }
    }
}
