using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print pi to the indicated number of places
            const double pi = Math.PI;
            Console.WriteLine("Please enter a number less than 10:");
            int round = Convert.ToInt32(Console.ReadLine());
            if (round <= 10)
            {
                Console.WriteLine(System.Math.Round(pi, round));
            }
            else
            {
                Console.WriteLine("Please enter a number less than 10.");
                round = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(System.Math.Round(pi, round));
            }

            // Print e to the indicated number of places
            const double ePlace = Math.E;
            Console.WriteLine("Please enter a number:");
            int round2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(System.Math.Round(ePlace, round2));

            // Print fibonacci
            Console.WriteLine("Please indicate how many digits you would like to print from the sequence.");
            int placeFib = Convert.ToInt32(Console.ReadLine());
            int i = 1, a = 0, b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            int c;
            while (i < placeFib)
            {
                c = (a + b);
                Console.WriteLine(c);
                a = b;
                b = c;
                i++;
            }

            // Fizzbuzz
            int iCount = 1;
            while (iCount <= 100)
            {
                if (iCount % 3 == 0)
                {
                    if (iCount % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz!");
                        iCount++;
                    }
                    else
                    {
                        Console.WriteLine("Fizz!");
                        iCount++;
                    }
                }
                else if (iCount % 5 == 0)
                {
                    Console.WriteLine("Buzz!");
                    iCount++;
                }
                else
                {
                    Console.WriteLine("Nah.");
                    iCount++;
                }
            }

            // Calculating square foot cost

            Console.WriteLine("Please enter the width of the room:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the length of the room:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please select the material you would like to use:");
            string matUsed = Console.ReadLine();
            decimal cost = flooring(matUsed);
            Console.WriteLine((cost * (width * length)));

        }

        static decimal flooring (string material)
        {
            if (material == "wood" || material == "Wood" || material == "WOOD")
            {
                decimal floorCost = 12;
                return floorCost;
            }
            else if (material == "metal")
            {
                decimal floorCost = 99;
                return floorCost;
            }
            else
            {
                decimal floorCost = 0;
                return floorCost;
            }
        }

        
    }
}
