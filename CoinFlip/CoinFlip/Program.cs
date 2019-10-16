using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many times would you like to flip the coin?");
            string flipper = Console.ReadLine();
            int flips = Convert.ToInt32(flipper);
            int count = 0, headscount = 0, tailscount = 0;
            bool coins = false;
            Random rnd = new Random();
            while (count < flips)
            {
                int roll = rnd.Next(1, 5);
                if (roll == 1 || roll == 3 || roll == 5)
                {
                    coins = true;
                }
                else
                {
                    coins = false;
                }

                if (coins == true)
                {
                    headscount++;
                    count++;
                }
                else
                {
                    tailscount++;
                    count++;
                }
            }
            Console.WriteLine("You flipped the coin " + count + " times, flipping " + headscount + " heads and " + tailscount + " tails.");
        }
    }
}