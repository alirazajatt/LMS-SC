namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataMapTuple")]
    public partial class DataMapTuple
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(224)]
        public string SourceFieldID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(224)]
        public string SinkFieldID { get; set; }

        [Required]
        public string TransformConfig { get; set; }

        [Required]
        public string SourceFieldType { get; set; }

        [Required]
        public string SinkFieldType { get; set; }

        public virtual DataMap DataMap { get; set; }
    }
}
