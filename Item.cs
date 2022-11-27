using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaiserville_Shop_Randomizer
{
    public class Item
    {

        public string itemName;
        public string secondayName;
        public int count;
        public int quality;
        public int price;
        public string category;
        public Item(string ItemName, string SecondayName, int Count, int Quality, int Price, string Category)
        {
            itemName = ItemName;
            secondayName = SecondayName;
            count = Count;
            quality = Quality;
            price = Price;
            category = Category;

        }

        
    }
}