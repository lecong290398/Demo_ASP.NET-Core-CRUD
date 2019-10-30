using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_CRUD.Models
{
    public partial class W_ReviewOfProduct
    {
        [Key]
        [StringLength(50)]
        public string ID { get; set; }
        [Required]
        [StringLength(50)]
        public string FK_WProduct { get; set; }
        [Required]
        [StringLength(500)]
        public string ReviewName { get; set; }
        [Required]
        [StringLength(500)]
        public string ReviewContent { get; set; }
        public int Rating { get; set; }
        public int ShowIndex { get; set; }
        public bool? CheckReview { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateReview { get; set; }
    }
}
