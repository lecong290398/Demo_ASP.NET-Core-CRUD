using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_CRUD.Models
{
    public partial class W_UserGroup
    {
        [Key]
        [StringLength(50)]
        public string ID { get; set; }
        [Required]
        [StringLength(100)]
        public string GroupUserName { get; set; }
        [StringLength(500)]
        public string GroupUserDes { get; set; }
    }
}
