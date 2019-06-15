using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleECommerce.Models
{
   public enum Type//Represent the main Category of item
    {
        Accessories,//we should make it an object that every single type has it own properties
        Computer,
        Clothes,
        Books
    }
    public class ItemCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }//spacific Cat. of Item
        public Type Type { get; set; }
        public List<Item> Items { get; set; }
    }
}