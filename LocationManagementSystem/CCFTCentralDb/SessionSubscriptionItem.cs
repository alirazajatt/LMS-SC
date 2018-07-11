namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SessionSubscriptionItem")]
    public partial class SessionSubscriptionItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SessionSubscriptionItem()
        {
            SessionBookmarks = new HashSet<SessionBookmark>();
        }

        public int SubscriptionID { get; set; }

        [Key]
        public int SubscriptionItemID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(2048)]
        public string Url { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SessionBookmark> SessionBookmarks { get; set; }

        public virtual SessionSubscription SessionSubscription { get; set; }
    }
}
