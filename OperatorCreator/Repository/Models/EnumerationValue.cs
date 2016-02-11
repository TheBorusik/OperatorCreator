namespace OperatorCreator.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EnumerationValue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EnumerationValue()
        {
            FieldsVisibilityCombinations = new HashSet<FieldsVisibilityCombination>();
            SelectorValues = new HashSet<SelectorValue>();
        }

        public int EnumerationValueId { get; set; }

        public int EnumerationId { get; set; }

        [Required]
        [StringLength(50)]
        public string Value { get; set; }

        [Required]
        public string StringValue { get; set; }

        public bool IsEnabled { get; set; }

        public DateTime BeginOfActivity { get; set; }

        public DateTime EndOfActivity { get; set; }

        public virtual Enumeration Enumeration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FieldsVisibilityCombination> FieldsVisibilityCombinations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SelectorValue> SelectorValues { get; set; }
    }
}
