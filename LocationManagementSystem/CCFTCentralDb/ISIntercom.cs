namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ISIntercom")]
    public partial class ISIntercom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ISIntercom()
        {
            JacquesIntercomViewerConfigPanelIntercoms = new HashSet<JacquesIntercomViewerConfigPanelIntercom>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public int IntercomSystemID { get; set; }

        [Required]
        [StringLength(64)]
        public string IntercomNumber { get; set; }

        [Required]
        [StringLength(64)]
        public string SerialNumber { get; set; }

        public int WorkstationID { get; set; }

        public int DoorID { get; set; }

        public bool AcceptCalls { get; set; }

        public bool DisableTamper { get; set; }

        public virtual FTItem FTItem { get; set; }

        public virtual IntercomSystem IntercomSystem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JacquesIntercomViewerConfigPanelIntercom> JacquesIntercomViewerConfigPanelIntercoms { get; set; }
    }
}
