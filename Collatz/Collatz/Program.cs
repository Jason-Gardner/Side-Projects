using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collatz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer greater than 1.");
            string roller = Console.ReadLine();
            int rollerI = Convert.ToInt32(roller);
            int counter = 0;
            bool truth = false;
            while (truth != true)
            {
                if (rollerI > 1)
                {
                    if (rollerI % 2 == 0)
                    {
                        counter++;
                        rollerI /= 2;
                    }
                    else
                    {
                        counter++;
                        rollerI = (rollerI * 3) + 1;
                    }
                }
                else
                {
                    Console.WriteLine("It took " + counter + " steps to get to one.");
                    truth = true;
                }

                
            }

        }
    }
}
