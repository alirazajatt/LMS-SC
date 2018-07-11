namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SharedBinary")]
    public partial class SharedBinary
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SharedBinary()
        {
            ReportDefinitions = new HashSet<ReportDefinition>();
            ReportDefinitions1 = new HashSet<ReportDefinition>();
        }

        public Guid ID { get; set; }

        [Required]
        public byte[] BinaryData { get; set; }

        public int Checksum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportDefinition> ReportDefinitions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportDefinition> ReportDefinitions1 { get; set; }
    }
}
