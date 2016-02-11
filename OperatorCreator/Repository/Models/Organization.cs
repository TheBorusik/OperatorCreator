namespace OperatorCreator.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Organization
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationId { get; set; }

        [Required]
        [StringLength(1024)]
        public string Name { get; set; }

        public bool IsEnabled { get; set; }
    }
}
