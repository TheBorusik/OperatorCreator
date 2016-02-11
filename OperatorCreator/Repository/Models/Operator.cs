namespace OperatorCreator.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Operator
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Operator()
        {
            FieldsVisibilityRules = new HashSet<FieldsVisibilityRule>();
            Selectors = new HashSet<Selector>();
            SelectorsMetadatas = new HashSet<SelectorsMetadata>();
            Services = new HashSet<Service>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OperatorId { get; set; }

        [Required]
        public string Name { get; set; }

        public int? LogoId { get; set; }

        public string Handler { get; set; }

        public string FieldsComment { get; set; }

        public int? AgreementId { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? MaxAmount { get; set; }

        public bool IsOfflineSupported { get; set; }

        public string Commission { get; set; }

        public string PrintTemplate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TypeOperator { get; set; }

        public bool IsEnable { get; set; }

        public int? CountryId { get; set; }

        public bool ShowInProtocol { get; set; }

        public bool IdentifyRequired { get; set; }

        public string Category { get; set; }

        public string Region { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FieldsVisibilityRule> FieldsVisibilityRules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Selector> Selectors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SelectorsMetadata> SelectorsMetadatas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Service> Services { get; set; }
    }
}
