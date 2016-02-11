namespace OperatorCreator.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ServiceRecipientDetail
    {
        [Key]
        public int ServiceRecipientDetailsMetadataId { get; set; }

        public int ServiceRecipientId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string PropertyName { get; set; }

        [Required]
        public string Value { get; set; }

        public int Visibility { get; set; }

        public virtual ServiceRecipient ServiceRecipient { get; set; }
    }
}
