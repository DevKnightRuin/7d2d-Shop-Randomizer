using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Kaiserville_Shop_Randomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            DBManager db = new DBManager();
            FileManager fileManager = new FileManager();
            
            List<Item> ShopList = new List<Item>();
            
            ShopList = db.GetItemShopList();
            List<string> itemlist = new List<string>();
            
            foreach(Item item in ShopList)
                itemlist.Add(db.ConvertToXmlFormat(item));
            
            fileManager.SavetoXml(itemlist);
        }
    }
}

