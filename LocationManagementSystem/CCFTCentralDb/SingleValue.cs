namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SingleValue
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Version { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SystemOperatorID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RootDivisionID { get; set; }

        public int? SiteSerialNumber { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChallengeShowFirstName { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChallengeShowLastName { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChallengeShowDescription { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChallengeShowCardNumber { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChallengeOperatorComment { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChallengeAudioType { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(260)]
        public string ChallengeAudioFile { get; set; }

        public byte[] ChallengeAudioData { get; set; }

        [StringLength(7)]
        public string SiteACCT { get; set; }

        [Key]
        [Column(Order = 10)]
        [MaxLength(32)]
        public byte[] Validation { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StateMapping { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AlarmNotesPriority { get; set; }

        [StringLength(32)]
        public string MifareSiteKey { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AllowUSBUpgrades { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DownloadLimit { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VisitPurgeTimeOfDay { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VisitPurgeAgeInDays { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NotifyEmailOutEnabled { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(50)]
        public string NotifyEmailOutAccount { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(50)]
        public string NotifyEmailOutServer { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NotifyEmailOutPort { get; set; }

        [Key]
        [Column(Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NotifyEmailOutSSL { get; set; }

        [Key]
        [Column(Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NotifySMSOutEnabled { get; set; }

        [Key]
        [Column(Order = 23)]
        [StringLength(1024)]
        public string NotifySMSOutDomain { get; set; }

        [Key]
        [Column(Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SMSRequiresEmail { get; set; }

        [Key]
        [Column(Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NotifySMSOutFormat { get; set; }

        [Key]
        [Column(Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NotifyExpiryTime { get; set; }

        [Key]
        [Column(Order = 27)]
        public DateTime LastExpiryCheck { get; set; }

        [Key]
        [Column(Order = 28)]
        public bool EnableConfirmedAlarms { get; set; }

        [Key]
        [Column(Order = 29)]
        public bool DisableAlarmIndications { get; set; }

        [Key]
        [Column(Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NotifyEmailInEnabled { get; set; }

        [Key]
        [Column(Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NotifyEmailInProtocol { get; set; }

        [Key]
        [Column(Order = 32)]
        [StringLength(50)]
        public string NotifyEmailInAccount { get; set; }

        [Key]
        [Column(Order = 33)]
        [StringLength(50)]
        public string NotifyEmailInServer { get; set; }

        [Key]
        [Column(Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NotifyEmailInPort { get; set; }

        [Key]
        [Column(Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NotifyEmailInSSL { get; set; }

        [Key]
        [Column(Order = 36)]
        [StringLength(32)]
        public string MifarePlusKey { get; set; }

        [Key]
        [Column(Order = 37)]
        [MaxLength(200)]
        public byte[] NotifyEmailOutPassword { get; set; }

        [Key]
        [Column(Order = 38)]
        [MaxLength(200)]
        public byte[] NotifyEmailInPassword { get; set; }

        [Key]
        [Column(Order = 39)]
        public bool DelayDialling { get; set; }

        [Key]
        [Column(Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NotifyEmailInInterval { get; set; }

        [Key]
        [Column(Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NotifyForwardAcks { get; set; }

        [Key]
        [Column(Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EnableKeyLoading { get; set; }

        [Key]
        [Column(Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UseDefaultKey { get; set; }

        [Key]
        [Column(Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EnableNetworkBasedKeyUpdate { get; set; }

        [Key]
        [Column(Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MifareSiteKeyVersion { get; set; }

        [Key]
        [Column(Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NotifySMSOutItemNameFormat { get; set; }

        [Key]
        [Column(Order = 47)]
        [StringLength(100)]
        public string NotifyEmailOutSender { get; set; }

        [Key]
        [Column(Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AddFacilityCodesToAdminCards { get; set; }

        [Key]
        [Column(Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WriteMifareKeyToAdminCard { get; set; }

        [Key]
        [Column(Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TemperatureUnit { get; set; }

        [Key]
        [Column(Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LongDistanceUnit { get; set; }

        [Key]
        [Column(Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShortDistanceUnit { get; set; }

        [Key]
        [Column(Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TensionUnit { get; set; }

        [Key]
        [Column(Order = 54)]
        public double Z10FastLowPassLearningRate { get; set; }

        [Key]
        [Column(Order = 55)]
        public double Z10SlowLowPassLearningRate { get; set; }

        [Key]
        [Column(Order = 56)]
        public double Z10WcRampTime { get; set; }

        [Key]
        [Column(Order = 57)]
        public double Z10WcHoldTime { get; set; }

        public int? UpgradeProgress { get; set; }

        [Key]
        [Column(Order = 58)]
        public bool PurgeAuditHistory { get; set; }

        [Key]
        [Column(Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PurgeAuditHistoryDays { get; set; }

        [Key]
        [Column(Order = 60)]
        public bool AcknowledgeAlarmsOnDisarm { get; set; }

        [Key]
        [Column(Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AlarmListMinPriority { get; set; }

        [StringLength(60)]
        public string ArmingFailedMessage { get; set; }

        [Key]
        [Column(Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AutoProcessAlarmsPeriod { get; set; }

        [Key]
        [Column(Order = 63)]
        public bool ViewAckdAlarmsOnDisarm { get; set; }

        [StringLength(200)]
        public string SiteMailUserAgentId { get; set; }

        [Key]
        [Column(Order = 64)]
        public bool ShowIdleImage { get; set; }

        [Key]
        [Column(Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WebServerBasePort { get; set; }

        [StringLength(32)]
        public string MifareClassicSiteKey { get; set; }

        [Key]
        [Column(Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FailedLogonAttempt { get; set; }

        [Key]
        [Column(Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubsequentFailedLogonAttempt { get; set; }

        [Key]
        [Column(Order = 68)]
        public bool EnableLockout { get; set; }
    }
}
