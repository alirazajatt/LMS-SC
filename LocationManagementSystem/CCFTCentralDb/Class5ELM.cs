namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Class5ELM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public bool WalktestEnabled { get; set; }

        public bool WalktestPolarity { get; set; }

        public bool WalktestInverted { get; set; }

        public virtual SiteItem SiteItem { get; set; }
    }
}
