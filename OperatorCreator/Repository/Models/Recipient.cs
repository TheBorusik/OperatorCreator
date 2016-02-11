namespace OperatorCreator.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Recipient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Recipient()
        {
            RecipientDetailsMetadatas = new HashSet<RecipientDetailsMetadata>();
            ServiceRecipients = new HashSet<ServiceRecipient>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RecipientId { get; set; }

        [StringLength(12)]
        public string INN { get; set; }

        public string Bank { get; set; }

        [StringLength(100)]
        public string Rs { get; set; }

        [StringLength(100)]
        public string Ls { get; set; }

        [StringLength(100)]
        public string Ks { get; set; }

        [StringLength(100)]
        public string OKATO { get; set; }

        [StringLength(100)]
        public string Bik { get; set; }

        [StringLength(100)]
        public string Kpp { get; set; }

        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecipientDetailsMetadata> RecipientDetailsMetadatas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceRecipient> ServiceRecipients { get; set; }
    }
}
