namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SpringType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SpringType()
        {
            TautWireGroups = new HashSet<TautWireGroup>();
        }

        public int ID { get; set; }

        public int NameKeyCode { get; set; }

        [StringLength(64)]
        public string Name { get; set; }

        public double Travel { get; set; }

        public double BindPoint { get; set; }

        public double Preload { get; set; }

        public double SpringRate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TautWireGroup> TautWireGroups { get; set; }
    }
}
