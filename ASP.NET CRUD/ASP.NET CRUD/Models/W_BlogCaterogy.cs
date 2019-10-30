using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_CRUD.Models
{
    public partial class W_BlogCaterogy
    {
        [Key]
        [StringLength(50)]
        public string ID { get; set; }
        [Required]
        [StringLength(500)]
        public string BlogCategoryName { get; set; }
        [Required]
        [StringLength(500)]
        public string MetaTitle { get; set; }
        [Required]
        [StringLength(500)]
        public string MetaKeyword { get; set; }
        [Required]
        [StringLength(500)]
        public string MetaDes { get; set; }
        public int ShowIndex { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string ModifiedBy { get; set; }
    }
}
