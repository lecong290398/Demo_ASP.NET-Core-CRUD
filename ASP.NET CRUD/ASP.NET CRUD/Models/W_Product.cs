using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_CRUD.Models
{
    public partial class W_Product
    {
        [Key]
        [StringLength(50)]
        public string ID { get; set; }
        [Required]
        [StringLength(50)]
        public string FK_WCategory { get; set; }
        [Required]
        [StringLength(50)]
        public string ProductCode { get; set; }
        [Required]
        [StringLength(500)]
        public string ProductName { get; set; }
        [StringLength(500)]
        public string MetaTitle { get; set; }
        [StringLength(500)]
        public string MetaKeyword { get; set; }
        [StringLength(500)]
        public string MetaDes { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal ProductPrice { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal ProductPriceSale { get; set; }
        [Required]
        [StringLength(1000)]
        public string ProductDesShor { get; set; }
        [Required]
        public string ProductDes { get; set; }
        public int Productindex { get; set; }
        public int ProductView { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string ModifiedBy { get; set; }
        [StringLength(100)]
        public string YoutubeLink { get; set; }
        [StringLength(500)]
        public string Tag { get; set; }
        public bool? StopSelling { get; set; }
        public bool? Acitve { get; set; }
        [StringLength(250)]
        public string ProductImage { get; set; }
    }
}
