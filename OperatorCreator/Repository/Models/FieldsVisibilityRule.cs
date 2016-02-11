namespace OperatorCreator.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FieldsVisibilityRule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FieldsVisibilityRule()
        {
            FieldsMetadatas = new HashSet<FieldsMetadata>();
            FieldsVisibilityCombinations = new HashSet<FieldsVisibilityCombination>();
            SelectorsMetadatas = new HashSet<SelectorsMetadata>();
        }

        [Key]
        public int VisibilityRuleId { get; set; }

        public int OperatorId { get; set; }

        public bool Visibility { get; set; }

        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FieldsMetadata> FieldsMetadatas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FieldsVisibilityCombination> FieldsVisibilityCombinations { get; set; }

        public virtual Operator Operator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SelectorsMetadata> SelectorsMetadatas { get; set; }
    }
}
