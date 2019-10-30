using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_CRUD.Models
{
    public partial class WeightUnit
    {
        [Key]
        [StringLength(50)]
        public string UnitID { get; set; }
        [Required]
        [StringLength(20)]
        public string UnitName { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool Inactive { get; set; }
        [Column(TypeName = "decimal(18, 12)")]
        public decimal KgRate { get; set; }
    }
}
