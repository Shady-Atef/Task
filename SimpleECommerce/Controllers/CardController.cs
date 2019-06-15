using Newtonsoft.Json.Linq;
using SimpleECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleECommerce.Controllers
{
    public class CardController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
       static List<Item> items = new List<Item>();
        // GET: Card
        [HttpPost]
        public ActionResult Index(string JsonLocalStorageObj)
        {

            List<Item> CardItems = new List<Item>();
            if (JsonLocalStorageObj != null) { 
            foreach (char item in JsonLocalStorageObj)
            {
                int itemid;
                bool isnumber = int.TryParse(item.ToString() ,out itemid);
                if (isnumber)
                {
                    Item SelectedItem = db.Items.Where(i => i.ID == itemid).FirstOrDefault();
                    CardItems.Add(SelectedItem);
                }
                
                
            }
          //  int s =int.Parse( JsonLocalStorageObj);
          TempData["items"]= CardItems;
            return View  ();
            }
            else
            {
                return View();
            }
        }

        public ActionResult index ()
        {
           
           
            List<Item> newitems = (List<Item>)TempData["items"];
            if (newitems != null) { 
            foreach (var item in newitems)
            {
                items.Add(item);
            }
            }
            // TempData.Keep("items");
            // items =
            // items.Add()
            return View(items);
        }

        public ActionResult Delete(int id)
        {

           // Item selecteditem = db.Items.Where(i => i.ID == id).FirstOrDefault();
            //items.Remove(selecteditem);
            Item itemx = items.Where(m => m.ID == id).FirstOrDefault();
            items.Remove(itemx);


            return RedirectToAction("Index");
        }

    }
}