using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_CRUD.Models
{
    public partial class W_ProductOptionAndProduct
    {
        [Key]
        [StringLength(50)]
        public string FK_ProductOptionID { get; set; }
        [Key]
        [StringLength(50)]
        public string FK_ProductID { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Price { get; set; }
    }
}
