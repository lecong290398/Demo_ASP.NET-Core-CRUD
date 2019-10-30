using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_CRUD.Models
{
    public partial class W_SlideShowGroup
    {
        [Key]
        [StringLength(50)]
        public string ID { get; set; }
        [StringLength(500)]
        public string SlideShowGroupName { get; set; }
    }
}
