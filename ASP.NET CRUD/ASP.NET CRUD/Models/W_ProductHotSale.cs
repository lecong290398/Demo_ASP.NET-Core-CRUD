using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_CRUD.Models
{
    public partial class W_ProductHotSale
    {
        [Key]
        [StringLength(50)]
        public string ID { get; set; }
        [Required]
        [StringLength(50)]
        public string W_ProductID { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal ProductPrice { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal ProductPriceSale { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateSales { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateEnd { get; set; }
        public int Avaible { get; set; }
        public int Sold { get; set; }
        public bool? Active { get; set; }
        public int ShowIndex { get; set; }
    }
}
