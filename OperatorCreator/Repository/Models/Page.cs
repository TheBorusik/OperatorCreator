namespace OperatorCreator.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Page
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Page()
        {
            SelectorsMetadatas = new HashSet<SelectorsMetadata>();
        }

        public int PageId { get; set; }

        [Required]
        public string Filename { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Content { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SelectorsMetadata> SelectorsMetadatas { get; set; }
    }
}
