namespace OperatorCreator.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SelectorsMetadata")]
    public partial class SelectorsMetadata
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SelectorsMetadata()
        {
            FieldsVisibilityCombinations = new HashSet<FieldsVisibilityCombination>();
            SelectorValues = new HashSet<SelectorValue>();
        }

        [Key]
        public long SelectorMetadataId { get; set; }

        public int EnumerationId { get; set; }

        public string Title { get; set; }

        public string Comment { get; set; }

        public int OperatorId { get; set; }

        [Required]
        public string PropertyName { get; set; }

        [Required]
        public string Name { get; set; }

        public int? PageId { get; set; }

        public bool IsArray { get; set; }

        public int FieldOrder { get; set; }

        public bool ExcludeFromServiceSelection { get; set; }

        public int? VisibilityRuleId { get; set; }

        [StringLength(250)]
        public string Helper { get; set; }

        public int Visibility { get; set; }

        public int? CheckOrder { get; set; }

        public int? DetailMetadataId { get; set; }

        public int? FormatedValueDetailsMetadataId { get; set; }

        public virtual DetailsMetadata DetailsMetadata { get; set; }

        public virtual DetailsMetadata DetailsMetadata1 { get; set; }

        public virtual Enumeration Enumeration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FieldsVisibilityCombination> FieldsVisibilityCombinations { get; set; }

        public virtual FieldsVisibilityRule FieldsVisibilityRule { get; set; }

        public virtual Operator Operator { get; set; }

        public virtual Page Page { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SelectorValue> SelectorValues { get; set; }
    }
}
