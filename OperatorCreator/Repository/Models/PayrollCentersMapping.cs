namespace OperatorCreator.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PayrollCentersMapping")]
    public partial class PayrollCentersMapping
    {
        public int PayrollCentersMappingId { get; set; }

        public int IdClient { get; set; }

        public int IdPoint { get; set; }

        public int? OperatorId { get; set; }

        public int? ServiceRecipientId { get; set; }

        public int PayrollCenterId { get; set; }

        public DateTime? BeginOfActivity { get; set; }

        public DateTime? EndOfActivity { get; set; }
    }
}
