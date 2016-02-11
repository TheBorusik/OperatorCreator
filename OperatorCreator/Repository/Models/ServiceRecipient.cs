namespace OperatorCreator.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ServiceRecipient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceRecipient()
        {
            ServiceRecipientCommissions = new HashSet<ServiceRecipientCommission>();
            ServiceRecipientDetails = new HashSet<ServiceRecipientDetail>();
        }

        [Key]
        public int SelectorId { get; set; }

        public int ServiceId { get; set; }

        public int RecipientId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? MaxAmount { get; set; }

        public bool? IsFixed { get; set; }

        public bool IsRequired { get; set; }

        public DateTime? BeginOfActivity { get; set; }

        public DateTime? EndOfActivity { get; set; }

        [StringLength(50)]
        public string MinCommission { get; set; }

        [StringLength(50)]
        public string MaxCommission { get; set; }

        [Column(TypeName = "money")]
        public decimal? MaxAmountAuth { get; set; }

        public virtual Recipient Recipient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceRecipientCommission> ServiceRecipientCommissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceRecipientDetail> ServiceRecipientDetails { get; set; }

        public virtual Service Service { get; set; }
    }
}
