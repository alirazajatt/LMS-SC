namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Division")]
    public partial class Division
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Division()
        {
            CardholderInductionMaterialReads = new HashSet<CardholderInductionMaterialRead>();
            Division1 = new HashSet<Division>();
            DivisionDescendants = new HashSet<DivisionDescendant>();
            DivisionDescendants1 = new HashSet<DivisionDescendant>();
            DivisionInductionMaterials = new HashSet<DivisionInductionMaterial>();
            DivisionInductionMaterialGroups = new HashSet<DivisionInductionMaterialGroup>();
            DivisionKioskMessages = new HashSet<DivisionKioskMessage>();
            OperatorClubDivisions = new HashSet<OperatorClubDivision>();
            OperatorSessions = new HashSet<OperatorSession>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public int? ParentID { get; set; }

        public int VisitorOverdueGraceTime { get; set; }

        public bool ConfigurationActive { get; set; }

        [Required]
        [StringLength(32)]
        public string TimeZone { get; set; }

        public int StandardVisitStartTime { get; set; }

        public int StandardVisitEndTime { get; set; }

        public int HomeTimeRangePast { get; set; }

        public int HomeTimeRangeFuture { get; set; }

        public int? CardTypeID { get; set; }

        public int? VisitorDivisionID { get; set; }

        public bool ExpireOverdueVisitorCards { get; set; }

        public int? KioskVisitorTypeID { get; set; }

        public int? KioskVisitorSearchPDFID { get; set; }

        [Required]
        [StringLength(260)]
        public string KioskWallpaper { get; set; }

        [Required]
        [StringLength(260)]
        public string KioskWelcomeScreenMessage { get; set; }

        [Required]
        [StringLength(260)]
        public string KioskPrivacyStatement { get; set; }

        [Required]
        [StringLength(260)]
        public string KioskInductionMaterial { get; set; }

        [Required]
        [StringLength(260)]
        public string KioskConditionsOfEntry { get; set; }

        public int InductionMaterialRedisplayTimeUnit { get; set; }

        public int InductionMaterialRedisplayTime { get; set; }

        public bool KioskVisitorSearchPDFValueMandatory { get; set; }

        public int? KioskSuperHostGroupID { get; set; }

        public int? KioskAdministratorGroupID { get; set; }

        public int KioskInductionMaterialType { get; set; }

        public bool CancelIfLate { get; set; }

        public int CancelIfLateGraceTime { get; set; }

        public bool RescheduleLateVisits { get; set; }

        public int UninhibitedAccessZoneMode { get; set; }

        public int NotificationFlags { get; set; }

        public int? KioskRapidVisitorGroupID { get; set; }

        public int KioskGeneralScreenTimeout { get; set; }

        public int KioskInductionScreenTimeout { get; set; }

        public int KioskRegistrationCompleteScreenTimeout { get; set; }

        [Required]
        [StringLength(200)]
        public string KioskCameraMessage { get; set; }

        [Required]
        [StringLength(60)]
        public string KioskWelcomeScreenVisitorSignInButtonText { get; set; }

        [Required]
        [StringLength(60)]
        public string KioskWelcomeScreenTourGroupButtonText { get; set; }

        [Required]
        [StringLength(60)]
        public string KioskWelcomeScreenRapidEntryButtonText { get; set; }

        [Required]
        [StringLength(200)]
        public string KioskCompletionMessage { get; set; }

        public int KioskButtonBackgroundColour { get; set; }

        public int KioskButtonTextColour { get; set; }

        [Required]
        [StringLength(60)]
        public string KioskWelcomeScreenVisitorSignOutButtonText { get; set; }

        public int KioskVisitorRegistrationStatus { get; set; }

        [Required]
        [StringLength(260)]
        public string PreregisteredVisitsOnlyMessage { get; set; }

        public bool DisplayPrivacyStatement { get; set; }

        public bool DisplayUpdateVisitorDetails { get; set; }

        public bool DisplayCreateVisit { get; set; }

        public bool DisplayConditionsOfEntry { get; set; }

        public bool DisplayVisitorSigningOut { get; set; }

        public int KioskTourGroupRegistrationStatus { get; set; }

        public bool DisplayRapidEntryIdentifyVisitor { get; set; }

        public bool DisplaySelectTourGroupVisit { get; set; }

        public int AllowVisitCreationWithDefaults { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CardholderInductionMaterialRead> CardholderInductionMaterialReads { get; set; }

        public virtual FTItem FTItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Division> Division1 { get; set; }

        public virtual Division Division2 { get; set; }

        public virtual FTItem FTItem1 { get; set; }

        public virtual FTItem FTItem2 { get; set; }

        public virtual FTItem FTItem3 { get; set; }

        public virtual FTItem FTItem4 { get; set; }

        public virtual FTItem FTItem5 { get; set; }

        public virtual FTItem FTItem6 { get; set; }

        public virtual FTItem FTItem7 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DivisionDescendant> DivisionDescendants { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DivisionDescendant> DivisionDescendants1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DivisionInductionMaterial> DivisionInductionMaterials { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DivisionInductionMaterialGroup> DivisionInductionMaterialGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DivisionKioskMessage> DivisionKioskMessages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperatorClubDivision> OperatorClubDivisions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperatorSession> OperatorSessions { get; set; }
    }
}
