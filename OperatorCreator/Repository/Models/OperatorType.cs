namespace OperatorCreator.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OperatorType")]
    public partial class OperatorType
    {
        [Column(TypeName = "numeric")]
        public decimal Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Discription { get; set; }
    }
}
