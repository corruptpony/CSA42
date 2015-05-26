using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebshopContract
{
    public class Database
    {
        List<Item> items;
        public Database()
        {
            items = new List<Item>();
            items.Add(newItem("Dracula", 10.5, 5));
            items.Add(newItem("A room with a view", 15, 9));
            items.Add(newItem("Uncle Tom's Cabin", 12.5, 54));
        }

        private Item newItem(string id, double price, int stock)
        {
            Item i = new Item();
            i.ProductId = id;
            i.Price = price;
            i.Stock = stock;
            i.ProductInfo = "dit is een boek";
            i.onSale = true;
            return i;
        }

        public List<Item> getItems()
        {
            return items;
        }
    }
}
