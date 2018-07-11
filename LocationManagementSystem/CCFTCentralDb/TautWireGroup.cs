namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TautWireGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public int? ParentID { get; set; }

        public double FenceLength { get; set; }

        public double BayWidth { get; set; }

        public int SpringCount { get; set; }

        public int SpringType { get; set; }

        public int WireType { get; set; }

        public double AttackDeflection { get; set; }

        public double TensionHighThreshold { get; set; }

        public double TensionLowThreshold { get; set; }

        public double HistoricTemperatureHigh { get; set; }

        public double HistoricTemperatureLow { get; set; }

        public double TensionRangeOffset { get; set; }

        public double WorstCaseTensionIncrease { get; set; }

        public virtual SiteItem SiteItem { get; set; }

        public virtual SpringType SpringType1 { get; set; }

        public virtual WireType WireType1 { get; set; }
    }
}
