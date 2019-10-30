using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_CRUD.Models
{
    public partial class W_CommerceWebsite
    {
        [Key]
        [StringLength(50)]
        public string ID { get; set; }
        [StringLength(100)]
        public string WebsiteName { get; set; }
        [StringLength(500)]
        public string ShopID { get; set; }
        [StringLength(500)]
        public string PartnerID { get; set; }
        [StringLength(500)]
        public string APIKey { get; set; }
        [StringLength(500)]
        public string URL { get; set; }
        [StringLength(500)]
        public string Password { get; set; }
        [StringLength(50)]
        public string SaveStore { get; set; }
        [StringLength(50)]
        public string SaveSource { get; set; }
        public bool? IsSyncStore { get; set; }
        [StringLength(50)]
        public string Refix { get; set; }
        [StringLength(500)]
        public string WebhookUrl { get; set; }
        [StringLength(500)]
        public string LinkUrl { get; set; }
    }
}
