namespace OperatorCreator.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceRecipientCommission")]
    public partial class ServiceRecipientCommission
    {
        [Key]
        public int CommissionId { get; set; }

        public int SelectorId { get; set; }

        [Required]
        [StringLength(100)]
        public string Commission { get; set; }

        public int IdPoint { get; set; }

        public int IdClient { get; set; }

        public DateTime? BeginOfActivity { get; set; }

        public DateTime? EndOfActivity { get; set; }

        public int? HandlerId { get; set; }

        public int? PayrollCenterId { get; set; }

        public bool IsEnabled { get; set; }

        public int Currency { get; set; }

        public virtual PayrollCenter PayrollCenter { get; set; }

        public virtual ServiceRecipient ServiceRecipient { get; set; }
    }
}
