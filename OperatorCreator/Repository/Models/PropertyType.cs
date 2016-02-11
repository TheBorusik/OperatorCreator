namespace OperatorCreator.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PropertyType
    {
        [Key]
        public int TypeId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
