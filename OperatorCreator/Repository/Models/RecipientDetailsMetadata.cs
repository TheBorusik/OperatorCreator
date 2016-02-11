namespace OperatorCreator.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecipientDetailsMetadata")]
    public partial class RecipientDetailsMetadata
    {
        public int RecipientDetailsMetadataId { get; set; }

        public int RecipientId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string PropertyName { get; set; }

        [Required]
        public string Value { get; set; }

        public int Visibility { get; set; }

        public virtual Recipient Recipient { get; set; }
    }
}
