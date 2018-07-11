namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SessionBookmark")]
    public partial class SessionBookmark
    {
        [Key]
        public int SubscriptionBookmark { get; set; }

        public int SubscriptionItemID { get; set; }

        [Required]
        [StringLength(200)]
        public string ItemBookmark { get; set; }

        public virtual SessionSubscriptionItem SessionSubscriptionItem { get; set; }
    }
}
