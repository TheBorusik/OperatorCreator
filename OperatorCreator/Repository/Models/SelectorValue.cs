namespace OperatorCreator.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SelectorValue
    {
        public int SelectorValueId { get; set; }

        public int SelectorId { get; set; }

        public long MetadataId { get; set; }

        public int? ValueId { get; set; }

        public bool IsNull { get; set; }

        public virtual EnumerationValue EnumerationValue { get; set; }

        public virtual Selector Selector { get; set; }

        public virtual SelectorsMetadata SelectorsMetadata { get; set; }
    }
}
