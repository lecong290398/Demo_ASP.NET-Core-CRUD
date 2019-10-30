using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_CRUD.Models
{
    public partial class W_PostService
    {
        [Key]
        [StringLength(50)]
        public string ID { get; set; }
        [Required]
        [StringLength(50)]
        public string AccountObjectID { get; set; }
        [Required]
        [StringLength(500)]
        public string PostProviderName { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        public bool InActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateDate { get; set; }
        [Required]
        [StringLength(50)]
        public string CreateUser { get; set; }
        [Required]
        [StringLength(50)]
        public string Fk_PostAPIMethod { get; set; }
        [StringLength(500)]
        public string APIKey { get; set; }
        [StringLength(100)]
        public string APIUsername { get; set; }
        [StringLength(100)]
        public string APIPassword { get; set; }
        [StringLength(100)]
        public string SKAPI { get; set; }
        [StringLength(100)]
        public string SL { get; set; }
        [StringLength(500)]
        public string URLAPI { get; set; }
        [StringLength(500)]
        public string NameOfSender { get; set; }
        [StringLength(500)]
        public string EmailOfSender { get; set; }
        [StringLength(500)]
        public string PhoneOfSender { get; set; }
        [StringLength(500)]
        public string AddressOfSender { get; set; }
        [StringLength(50)]
        public string Fk_Provine { get; set; }
        [StringLength(50)]
        public string Fk_Dictrist { get; set; }
        [StringLength(50)]
        public string PostType { get; set; }
        [StringLength(50)]
        public string ServiceCode { get; set; }
        [StringLength(50)]
        public string ProductCode { get; set; }
        [StringLength(50)]
        public string PaymentType { get; set; }
        public bool? IsSanBox { get; set; }
        public bool? IsFreeShip { get; set; }
    }
}
