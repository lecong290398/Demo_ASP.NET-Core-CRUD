using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_CRUD.Models
{
    public partial class W_ColorOfProduct
    {
        [Key]
        [StringLength(50)]
        public string ID { get; set; }
        [Required]
        [StringLength(50)]
        public string ColorName { get; set; }
        [Required]
        [StringLength(500)]
        public string ColorImage { get; set; }
        public bool Acitive { get; set; }
    }
}
