using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            object[,] gradeArray = new object[6,2];
            gradeArray[0,0] = "Adams, Steve";
            gradeArray[1,0] = "Kelly, Dallas";
            gradeArray[2,0] = "Stephens, Xena";
            gradeArray[3,0] = "Lisk, Abbey";
            gradeArray[4,0] = "Davis, Suzie";
            gradeArray[5,0] = "Adams, Bree";

            Array.Sort(gradeArray);

            int count = 0;
            while (count < 6)
            {
                Console.WriteLine(gradeArray[count,0]);
                count++;
            }
            
        }
    }
}
