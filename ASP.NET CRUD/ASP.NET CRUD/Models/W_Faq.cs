using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_CRUD.Models
{
    public partial class W_Faq
    {
        [Key]
        [StringLength(50)]
        public string ID { get; set; }
        [Required]
        [StringLength(1000)]
        public string FAQQuestion { get; set; }
        [Required]
        [StringLength(2000)]
        public string FAQReply { get; set; }
        public int Showindex { get; set; }
        public bool Active { get; set; }
    }
}
