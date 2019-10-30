using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_CRUD.Models
{
    public partial class W_SubMenu
    {
        [Key]
        [StringLength(50)]
        public string ID { get; set; }
        [Required]
        [StringLength(50)]
        public string W_SubMenuGroup { get; set; }
        [Required]
        [StringLength(50)]
        public string MenuName { get; set; }
        [Required]
        [StringLength(500)]
        public string MetaTitle { get; set; }
        [Required]
        [StringLength(500)]
        public string MetaKeyword { get; set; }
        [Required]
        [StringLength(500)]
        public string MetaDes { get; set; }
        [Required]
        public string SubMenuDes { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedBy { get; set; }
        public int ShowIndex { get; set; }
        public bool Show { get; set; }
    }
}
