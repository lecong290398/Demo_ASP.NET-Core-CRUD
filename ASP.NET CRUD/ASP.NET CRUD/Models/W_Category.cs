using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_CRUD.Models
{
    public partial class W_Category
    {
        [Key]
        [StringLength(50)]
        public string ID { get; set; }
        [Required]
        [StringLength(500)]
        public string CategoryName { get; set; }
        [Required]
        [StringLength(500)]
        public string MetaTitle { get; set; }
        [Required]
        [StringLength(50)]
        public string CategoryParent { get; set; }
        [StringLength(500)]
        public string MetaKeyword { get; set; }
        [StringLength(500)]
        public string MetaDes { get; set; }
        [StringLength(500)]
        public string CategoryDes { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string ModifiedBy { get; set; }
        public int ShowIndex { get; set; }
        [Required]
        [StringLength(200)]
        public string CategoryLinks { get; set; }
        [Required]
        [StringLength(200)]
        public string CategoryIco { get; set; }
    }
}
