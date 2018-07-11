namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SessionSubscription")]
    public partial class SessionSubscription
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SessionSubscription()
        {
            SessionSubscriptionItems = new HashSet<SessionSubscriptionItem>();
        }

        public int SessionID { get; set; }

        [Key]
        public int SubscriptionID { get; set; }

        public virtual OperatorSession OperatorSession { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SessionSubscriptionItem> SessionSubscriptionItems { get; set; }
    }
}
