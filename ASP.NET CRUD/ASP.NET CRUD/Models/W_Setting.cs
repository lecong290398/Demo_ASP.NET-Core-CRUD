using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_CRUD.Models
{
    public partial class W_Setting
    {
        [Key]
        [StringLength(100)]
        public string SettingKey { get; set; }
        [Required]
        [StringLength(500)]
        public string SettingValue { get; set; }
    }
}
