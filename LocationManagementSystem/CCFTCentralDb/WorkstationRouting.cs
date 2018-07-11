namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkstationRouting")]
    public partial class WorkstationRouting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkstationRouting()
        {
            SessionOperatorRoutings = new HashSet<SessionOperatorRouting>();
            WorkstationRoutingLinkedItems = new HashSet<WorkstationRoutingLinkedItem>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public int? DisableMacroID { get; set; }

        public int? GroupAMacroID { get; set; }

        public int? GroupBMacroID { get; set; }

        public int RoutingState { get; set; }

        public DateTime? RoutingStateChangedAt { get; set; }

        public int? RoutingStateChangedBy { get; set; }

        [Required]
        [StringLength(200)]
        public string GroupAName { get; set; }

        [Required]
        [StringLength(200)]
        public string GroupBName { get; set; }

        public virtual Macro Macro { get; set; }

        public virtual Macro Macro1 { get; set; }

        public virtual Macro Macro2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SessionOperatorRouting> SessionOperatorRoutings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkstationRoutingLinkedItem> WorkstationRoutingLinkedItems { get; set; }
    }
}
