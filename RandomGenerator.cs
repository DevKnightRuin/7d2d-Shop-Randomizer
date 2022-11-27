using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaiserville_Shop_Randomizer
{
    internal class RandomGenerator
    {
        Random rand;
        

        public RandomGenerator() {

            rand = new Random(DateTime.Now.Millisecond);
        }

        //Used to return an item from the list to go into the shop list
        public int ReturnRandomNumber(int Max)
        {
            
            return rand.Next(0, Max - 1);
        }

        //Returns 2 random items from the list.  Remove each item so it doens't get selected twice
        public void ReturnRandomItems(int ReturnCount, List<Item> inList, List<Item> outList )
        {
            if (inList.Count <= 0)
            {
                Console.WriteLine("List is invalid");
                return;
            }
            // rand = new Random(DateTime.Now.Millisecond);
            rand.Next();
            for (int i = 0; i < ReturnCount; i++)
            {
                int randNum =  rand.Next(0, inList.Count()-1);
                outList.Add(inList[randNum]);
                inList.RemoveAt(randNum);
            }
        }


        public int ReturnRandomRarity()
        {
            //rand = new Random(DateTime.Now.Millisecond);
            rand.Next();
            int rarity = rand.Next(0, 100);
            if (rarity <  55)
                return 2;
            if (rarity <  63)
                return 3;
            if (rarity <  89)
                return 4;
            if (rarity <= 97)
                return 5;
            if (rarity > 97)
                return 6;

            return 2;
        }

        public void TestRarityOdds()
        {
            //use these for formatting and calculating total rarity number for high loop counts
            int Rarity_2 = 0;
            int Rarity_3 = 0;
            int Rarity_4 = 0;
            int Rarity_5 = 0;
            int Rarity_6 = 0;

            int temp = ReturnRandomNumber(10);
            //use this to test rarity returns
            switch(temp)
                {
                case 2:
                    Rarity_2++;
                    break;
                case 3:
                    Rarity_3++;
                    break;
                case 4:
                    Rarity_4++;
                    break;
                case 5:
                    Rarity_5++;
                    break;
                case 6:
                    Rarity_6++;
                    break;
                    default: throw new Exception("error with random");
                 }
            Thread.Sleep(5);
            Console.WriteLine( "Rarity 2-6: {0}, {1}, {2}, {3}, {4}", Rarity_2, Rarity_3, Rarity_4, Rarity_5, Rarity_6);
        }


        
    }
}
