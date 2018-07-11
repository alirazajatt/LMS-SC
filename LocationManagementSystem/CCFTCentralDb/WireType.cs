namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WireType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WireType()
        {
            TautWireGroups = new HashSet<TautWireGroup>();
        }

        public int ID { get; set; }

        public int NameKeyCode { get; set; }

        [StringLength(64)]
        public string Name { get; set; }

        public double CLTE { get; set; }

        public double YieldPoint { get; set; }

        public double CoilEffectTf { get; set; }

        public double CoilEffectC1 { get; set; }

        public double CoilEffectC2 { get; set; }

        public double ElasticModulus { get; set; }

        public double WireDiameter { get; set; }

        public double EndEffectTf { get; set; }

        public double EndEffectC1 { get; set; }

        public double EndEffectC2 { get; set; }

        public double EndEffectClock { get; set; }

        public double ExerciseMaxEnd { get; set; }

        public double ExerciseMinEnd { get; set; }

        public double ExerciseMaxLen { get; set; }

        public double ExerciseMinLen { get; set; }

        public int? DGUThresholdMin { get; set; }

        public int? FastThresholdMin { get; set; }

        public int? SlowThresholdMin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TautWireGroup> TautWireGroups { get; set; }
    }
}
