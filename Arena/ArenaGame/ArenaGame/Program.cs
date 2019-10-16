using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please name your hero:");
            string heroName = Console.ReadLine();
            Console.WriteLine("Please select your class: Archer(1), Knight(2), Barbarian(3)");
            int heroClass = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please select your difficulty: Easy(1), Advanced(2), Extreme(3)");
            int difficulty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("A new hero has emerged!");
            Console.WriteLine(heroName + " the " + classCreate(heroClass));
            int[,] heroStats = new int[3, 3];
            heroStats[0, 0] = 5; // Archer Stats
            heroStats[1, 0] = 7;
            heroStats[2, 0] = 5;
            heroStats[0, 1] = 6; // Knight Stats
            heroStats[1, 1] = 5;
            heroStats[2, 1] = 6;
            heroStats[0, 2] = 7; // Barbarian Stats
            heroStats[1, 2] = 4;
            heroStats[2, 2] = 6;

            int heroStr = heroStats[0, (heroClass - 1)];
            int heroDex = heroStats[1, (heroClass - 1)];
            int heroEnd = heroStats[2, (heroClass - 1)];

            Console.WriteLine();
            Console.WriteLine(heroStr + " STRENGTH " + heroDex + " DEXTERITY " + heroEnd + " ENDURANCE");

            bool game = true;
            while (game != false)
            {
                Console.WriteLine(heroName + " has encountered a monster!");
                int[] monsterStats = new int[3];
                switch (difficulty)
                {
                    case 1:
                        monsterStats = new int[] { 2, 1, 12 };
                        break;
                    case 2:
                        monsterStats = new int[] { 3, 2, 26 };
                        break;
                    case 3:
                        monsterStats = new int[] { 4, 3, 49 };
                        break;
                    default:
                        Console.WriteLine("Error.");
                        break;
                }
                Console.WriteLine("This monster has " + monsterStats[0] + " strength, " + monsterStats[1] + " dexterity and " + monsterStats[2] + " endurance.");

                Random roller = new Random();
                bool fight = true;
                while (monsterStats[2] > 0 && fight != false)
                {
                    Console.WriteLine("What would you like to do? (A)ttack or (R)un?");
                    string fightX = Console.ReadLine();
                    if (fightX == "A" || fightX == "a")
                    {
                        int attack = roller.Next(heroStr);
                        if (attack > (monsterStats[1]))
                        {
                            monsterStats[2] = (monsterStats[2] - attack);
                            Console.WriteLine("You attack and hit for " + attack + " damage!");
                        }
                        else
                        {
                            Console.WriteLine("You missed!");
                            heroEnd = (heroEnd - 1);
                            if (heroEnd == 0)
                            {
                                Console.WriteLine("YOU DIED.");
                                Console.ReadLine();
                                fight = false;
                            }
                        }
                    }

                }

                if (fight == true)
                {
                    int experience = 0;
                    experience = +difficulty;
                    Console.WriteLine("The monster has been defeated.");
                    heroEnd = heroStats[2, (heroClass - 1)];



                    if (experience > 10)
                    {
                        Console.WriteLine("Level up!");
                        heroStr = heroStats[0, (heroClass - 1)] + difficulty;
                        heroDex = heroStats[1, (heroClass - 1)] + difficulty;
                        heroEnd = heroStats[2, (heroClass - 1)] + difficulty;

                        Console.WriteLine("Your new stats are:");
                        Console.WriteLine(heroStr + " STRENGTH " + heroDex + " DEXTERITY " + heroEnd + " ENDURANCE");
                        experience -= 10;
                    }
                }

                Console.WriteLine("Would you like to fight again?");
                if (Console.ReadLine() == "N" || Console.ReadLine() == "n")
                {
                    game = false;
                }
            }
        }


        static string classCreate(int classNum)
        {
            if (classNum == 1)
            {
                string yourClass = "Archer";
                return yourClass;
            }
            else if (classNum == 2)
            {
                string yourClass = "Knight";
                return yourClass;
            }
            else
            {
                string yourClass = "Barbarian";
                return yourClass;
            }
        }
    }
}

        
    

