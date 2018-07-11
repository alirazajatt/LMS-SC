namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReportDefinitionEmailRecipient")]
    public partial class ReportDefinitionEmailRecipient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReportID { get; set; }

        public int? CardholderID { get; set; }

        [StringLength(200)]
        public string EmailAddress { get; set; }

        public virtual Cardholder Cardholder { get; set; }

        public virtual ReportDefinition ReportDefinition { get; set; }
    }
}
