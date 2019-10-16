using System;

namespace UnitConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a data type to convert.");
            Console.WriteLine("Temperature(1), Distance(2), Weight (3), Height (4)");
            string dataChoice = Console.ReadLine();
            int choice = Convert.ToInt32(dataChoice);
            switch (choice)
            {
                case 1:
                    Console.WriteLine(tempConvert(choice));
                    break;
                case 2:
                    Console.WriteLine(distConvert(choice));
                    break;
                case 3:
                    Console.WriteLine(weightConvert(choice));
                    break;
                case 4:
                    Console.WriteLine(heightConvert(choice));
                    break;
                default:
                    Console.WriteLine("Error.");
                    break;
            }
            Console.WriteLine("Goodbye!");
        }

        static double tempConvert(int choice)
        {
            Console.WriteLine("Please enter a number.");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter if this is being entered in F or C.");
            char tempType = Convert.ToChar(Console.ReadLine());
            if (tempType == 'F' || tempType == 'f')
            {
                double converted = (((temp - 32) * (5) / 9));
                return converted;
            }
            else
            {
                double converted = (temp * (9 / 5) + 32);
                return converted;
            }

        }

        static double distConvert (int choice)
        {
            Console.WriteLine("Please enter a length.");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter if this is being enter in miles (M) or kilometers(K).");
            char lengthType = Convert.ToChar(Console.ReadLine());
            if (lengthType == 'M' || lengthType == 'm')
            {
                double conLength = (length / (0.62));
                return conLength;
            }
            else
            {
                double conLength = (length * (0.62));
                return conLength;
            }
        }

        static double weightConvert(int choice)
        {
            Console.WriteLine("Please enter a weight.");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter if this is being enter in kilograms(k) or pounds(p).");
            char weightType = Convert.ToChar(Console.ReadLine());
            if (weightType == 'P' || weightType == 'p')
            {
                double conWeight = (weight / (2.2));
                return conWeight;
            }
            else
            {
                double conWeight = (weight * (2.2));
                return conWeight;
            }
        }

        static double heightConvert(int choice)
        {
            Console.WriteLine("Please enter a height.");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter if this is being enter in feet(F) or meters(M).");
            char heightType = Convert.ToChar(Console.ReadLine());
            if (heightType == 'F' || heightType == 'f')
            {
                double conHeight = (height / 3);
                return conHeight;
            }
            else
            {
                double conHeight = (height * 3);
                return conHeight;
            }
        }
    }
}
