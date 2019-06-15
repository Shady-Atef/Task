using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SimpleECommerce.Models
{
    public class Invoice
    {
        [Key]
        [Display(Name = "Invoice ID")]
        public int invoiceID { get; set; }
        [Display(Name = "Quantity")]
        public int? Qty { get; set; }
        public int Total { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        [ForeignKey("ApplicationUser")]
        public string ClientId { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }


    }
}