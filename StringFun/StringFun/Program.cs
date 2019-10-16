using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name;
            name = Console.ReadLine();
            int nameLength = name.Length;
            Console.WriteLine("Your name is " + nameLength + " letters long.");
            Console.Write("Your name backwards is ");

            while (nameLength > 0)
            {
                Console.Write(name[nameLength - 1]);
                nameLength--; 
            }
            Console.WriteLine(".");

            Console.WriteLine("Enter four numbers between 0 and " + (name.Length - 1));
            int inquire1 = Convert.ToInt32(Console.ReadLine());
            int inquire2 = Convert.ToInt32(Console.ReadLine());
            int inquire3 = Convert.ToInt32(Console.ReadLine());
            int inquire4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your password is: ");
            string passWord = (name[inquire1 - 1] + "" + name[inquire2 - 1] + "" + name[inquire3 - 1] + "" + name[inquire4 - 1]);
            Console.WriteLine(passWord);
            Console.WriteLine("Please enter the password you have been given.");
            string whatSit = Console.ReadLine();
            if (whatSit == passWord)
            {
                Console.WriteLine("Congrats, a winrar is you!");
            }
            else
            {
                Console.WriteLine("Dummy!");
            }

        }
    }
}
