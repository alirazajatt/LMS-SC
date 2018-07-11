namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AlarmTransmitter")]
    public partial class AlarmTransmitter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AlarmTransmitter()
        {
            AlarmReceivers = new HashSet<AlarmReceiver>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FTItemID { get; set; }

        public bool Encrypt { get; set; }

        public int SendTimeout { get; set; }

        public int SendAttempts { get; set; }

        [StringLength(64)]
        public string EncryptionKey { get; set; }

        public int BandSet { get; set; }

        public int Protocol { get; set; }

        public bool Authenticate { get; set; }

        [StringLength(64)]
        public string Username { get; set; }

        [StringLength(64)]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlarmReceiver> AlarmReceivers { get; set; }

        public virtual FTItem FTItem { get; set; }
    }
}
