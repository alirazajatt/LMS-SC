namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Door")]
    public partial class Door
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Door()
        {
            ControlledChallengeViewerConfigPanelDoors = new HashSet<ControlledChallengeViewerConfigPanelDoor>();
            DoorPersonalDataFieldPairs = new HashSet<DoorPersonalDataFieldPair>();
            DoorRelations = new HashSet<DoorRelation>();
            Viewers = new HashSet<Viewer>();
            AccessZones = new HashSet<AccessZone>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public int PushbuttonExit { get; set; }

        public int PushbuttonEntry { get; set; }

        public int ChallengeOverrideDefaults { get; set; }

        public int ChallengeShowFirstName { get; set; }

        public int ChallengeShowLastName { get; set; }

        public int ChallengeShowDescription { get; set; }

        public int ChallengeShowCardNumber { get; set; }

        public int ChallengeOperatorComment { get; set; }

        public int ChallengeAudioType { get; set; }

        [Required]
        [StringLength(260)]
        public string ChallengeAudioFile { get; set; }

        public byte[] ChallengeAudioData { get; set; }

        public bool PlayUnsecuredTone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ControlledChallengeViewerConfigPanelDoor> ControlledChallengeViewerConfigPanelDoors { get; set; }

        public virtual SiteItem SiteItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoorPersonalDataFieldPair> DoorPersonalDataFieldPairs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoorRelation> DoorRelations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Viewer> Viewers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccessZone> AccessZones { get; set; }
    }
}
