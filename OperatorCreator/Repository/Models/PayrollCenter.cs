namespace OperatorCreator.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PayrollCenter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PayrollCenter()
        {
            PayrollCentersAccounts = new HashSet<PayrollCentersAccount>();
            ServiceRecipientCommissions = new HashSet<ServiceRecipientCommission>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PayrollCenterId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? HandlerId { get; set; }

        public int? OperatorId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Balance { get; set; }

        public DateTimeOffset? Timestamp { get; set; }

        [StringLength(50)]
        public string Owner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayrollCentersAccount> PayrollCentersAccounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceRecipientCommission> ServiceRecipientCommissions { get; set; }
    }
}
