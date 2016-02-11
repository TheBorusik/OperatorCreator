namespace OperatorCreator.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PayrollCentersAccount
    {
        public int Id { get; set; }

        public int PayrollCenterId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int Currency { get; set; }

        public bool IsEnabled { get; set; }

        [Column(TypeName = "money")]
        public decimal? Balance { get; set; }

        public DateTimeOffset? Timestamp { get; set; }

        public virtual PayrollCenter PayrollCenter { get; set; }
    }
}
