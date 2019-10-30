using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_CRUD.Models
{
    public partial class W_SlideShow
    {
        [Key]
        [StringLength(50)]
        public string ID { get; set; }
        [Required]
        [StringLength(50)]
        public string SlideShowGroup { get; set; }
        [Required]
        [StringLength(50)]
        public string NameSlideShow { get; set; }
        [Required]
        [StringLength(500)]
        public string ImagePath { get; set; }
        public int ShowIndex { get; set; }
        public bool Acitive { get; set; }
    }
}
