
using System;


namespace NumberPatterns
{
    public static class PatternGenerator
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Number Patterns Generator!");
            Console.WriteLine("Please type in one of the following pattern options for a pattern to be generated:");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. RightAngleTriangle");
            Console.WriteLine("3. Diamond");
            Console.WriteLine("4. Hexagon");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Square();
                    break;
                case "2":
                    RightAngleTriangle();
                    break;
                case "3":
                    Diamond();
                    break;
                case "4":
                    Hexagon();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        private static void Square()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("*****");
            }
        }

        private static void RightAngleTriangle()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }

        private static void Diamond()
        {
            for (int i = 1; i <= 5; i += 2)
            {
                Console.WriteLine(new string(' ', (5 - i) / 2) + new string('*', i));
            }
            for (int i = 3; i > 0; i -= 2)
            {
                Console.WriteLine(new string(' ', (5 - i) / 2) + new string('*', i));
            }
        }

        private static void Hexagon()
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 0 || i == 4)
                {
                    Console.WriteLine(" *** ");
                }
                else
                {
                    Console.WriteLine("*****");
                }
            }
        }
    }
}
