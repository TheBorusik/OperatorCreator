namespace OperatorCreator.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FieldsMetadata")]
    public partial class FieldsMetadata
    {
        [Key]
        public int FieldMetadataId { get; set; }

        public int OperatorId { get; set; }

        public int PropertyTypeId { get; set; }

        public string Title { get; set; }

        public string Comment { get; set; }

        public string PropertyName { get; set; }

        public int? DetailsMetadataId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Format { get; set; }

        public string MinValue { get; set; }

        public string MaxValue { get; set; }

        public int? PageId { get; set; }

        public bool? IsRequired { get; set; }

        public int? FieldOrder { get; set; }

        public int? VisiblityRuleId { get; set; }

        [StringLength(250)]
        public string Helper { get; set; }

        public string Display { get; set; }

        public int Visibility { get; set; }

        public int? CheckOrder { get; set; }

        public string PrintFormat { get; set; }

        public string DefaultValue { get; set; }

        public virtual FieldsVisibilityRule FieldsVisibilityRule { get; set; }
    }
}
