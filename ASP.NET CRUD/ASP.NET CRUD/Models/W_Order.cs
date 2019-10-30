using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_CRUD.Models
{
    public partial class W_Order
    {
        [Key]
        [StringLength(50)]
        public string ID { get; set; }
        [Required]
        [StringLength(50)]
        public string W_Customer { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal Totalmoney { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }
        [Required]
        [StringLength(500)]
        public string CustomerAddress { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerPhone { get; set; }
        [StringLength(500)]
        public string OrderNote { get; set; }
    }
}
