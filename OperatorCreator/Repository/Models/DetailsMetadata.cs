namespace OperatorCreator.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetailsMetadata")]
    public partial class DetailsMetadata
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DetailsMetadata()
        {
            SelectorsMetadatas = new HashSet<SelectorsMetadata>();
            SelectorsMetadatas1 = new HashSet<SelectorsMetadata>();
        }

        public int DetailsMetadataId { get; set; }

        [Required]
        public string TableName { get; set; }

        [Required]
        [StringLength(50)]
        public string TableColumn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SelectorsMetadata> SelectorsMetadatas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SelectorsMetadata> SelectorsMetadatas1 { get; set; }
    }
}
