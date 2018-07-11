namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OperatorSession")]
    public partial class OperatorSession
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OperatorSession()
        {
            SessionOperatorAccesses = new HashSet<SessionOperatorAccess>();
            SessionOperatorClubs = new HashSet<SessionOperatorClub>();
            SessionOperatorRoutings = new HashSet<SessionOperatorRouting>();
            SessionPermissions = new HashSet<SessionPermission>();
            SessionSubscriptions = new HashSet<SessionSubscription>();
        }

        public int ID { get; set; }

        public int OperatorID { get; set; }

        public int? WorkstationID { get; set; }

        public DateTime LogonTime { get; set; }

        public int? CurrentDivisionID { get; set; }

        [StringLength(128)]
        public string TerminalServicesSessionName { get; set; }

        [StringLength(255)]
        public string WorkstationName { get; set; }

        public int SessionType { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastContactTime { get; set; }

        [MaxLength(32)]
        public byte[] Token { get; set; }

        public int LocaleID { get; set; }

        public int SessionState { get; set; }

        public virtual Division Division { get; set; }

        public virtual Operator Operator { get; set; }

        public virtual WorkstationBase WorkstationBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SessionOperatorAccess> SessionOperatorAccesses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SessionOperatorClub> SessionOperatorClubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SessionOperatorRouting> SessionOperatorRoutings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SessionPermission> SessionPermissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SessionSubscription> SessionSubscriptions { get; set; }
    }
}
