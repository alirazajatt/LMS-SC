namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AlarmInstruction")]
    public partial class AlarmInstruction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AlarmInstruction()
        {
            AlarmInstructionAlarmNotes = new HashSet<AlarmInstructionAlarmNote>();
            EventGroupDefaultInstructions = new HashSet<EventGroupDefaultInstruction>();
            EventGroupItemAlarmInstructions = new HashSet<EventGroupItemAlarmInstruction>();
            EventTypeDefaultInstructions = new HashSet<EventTypeDefaultInstruction>();
            EventTypeItemAlarmInstructions = new HashSet<EventTypeItemAlarmInstruction>();
            InsertionTags = new HashSet<InsertionTag>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        [Required]
        public string Message { get; set; }

        public string url { get; set; }

        public bool UseSpecificAlarmNotes { get; set; }

        public virtual FTItem FTItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlarmInstructionAlarmNote> AlarmInstructionAlarmNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventGroupDefaultInstruction> EventGroupDefaultInstructions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventGroupItemAlarmInstruction> EventGroupItemAlarmInstructions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventTypeDefaultInstruction> EventTypeDefaultInstructions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventTypeItemAlarmInstruction> EventTypeItemAlarmInstructions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InsertionTag> InsertionTags { get; set; }
    }
}
