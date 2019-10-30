using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_CRUD.Models
{
    public partial class W_ProductAndTag
    {
        [Key]
        [StringLength(50)]
        public string FK_WProduct { get; set; }
        [Key]
        [StringLength(50)]
        public string FK_Tag { get; set; }
        public int ShowIndex { get; set; }
    }
}
