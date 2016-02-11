namespace OperatorCreator.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FieldsVisibilityCombination
    {
        [Key]
        public int FieldsVisibilityRuleCombinationId { get; set; }

        public int FieldVisibilityRuleId { get; set; }

        public long SelectorMetadataId { get; set; }

        public int EnumerationValueId { get; set; }

        public int FormulaId { get; set; }

        public virtual EnumerationValue EnumerationValue { get; set; }

        public virtual FieldsVisibilityRule FieldsVisibilityRule { get; set; }

        public virtual FieldsVisibilityFormula FieldsVisibilityFormula { get; set; }

        public virtual SelectorsMetadata SelectorsMetadata { get; set; }
    }
}
