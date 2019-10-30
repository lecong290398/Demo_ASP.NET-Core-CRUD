using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_CRUD.Models
{
    public partial class W_Email
    {
        [Key]
        [StringLength(50)]
        public string ID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Required]
        [StringLength(50)]
        public string EmailAddress { get; set; }
    }
}
