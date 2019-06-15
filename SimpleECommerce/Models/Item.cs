using SimpleECommerce.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SimpleECommerce.Models
{
    
    
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int? Sale_Price { get; set; }
        public string Image { get; set; }
        [ForeignKey("ItemCat")]
        public int CatID { get; set; }
        public ItemCategory  ItemCat { get; set; }
        public virtual ICollection<ApplicationUser>  ApplicationUsers { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}