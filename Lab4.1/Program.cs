using System;

namespace Lab4._1
{
    class Program
    {

        static string DiceRoll()
        {
            Random rand = new Random();
            int x = rand.Next(1, 7);
            int y = rand.Next(1, 7);
            string message = " ";

            Console.WriteLine($"You rolled a {x} and a {y}. {x + y} total.");

            if (x == 1 && y == 1)
            {
                message = "snake eyes";
                Console.WriteLine(message);
            }
            else if (x == 1 && y == 2)
            {
                message = "Ace Deuce";
                Console.WriteLine(message);
            }
            else if (x == 2 && y == 1)
            {
                message = "Ace Deuce";
                Console.WriteLine(message);
            }
            else if (x == 6 && y == 6)
            {
                message = "Box Cars";
                Console.WriteLine(message);
            }
            else if (x + y == 7 || x + y == 11)
            {
                message = "Win";
                Console.WriteLine(message);
            }
            else if (x + y == 2 || x + y == 3 || x + y == 12)
            {
                message = "Craps";
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("You lose :(");
            }
            return message;
            
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Casino!");

            bool cont = true;
            while (cont)
            {
                DiceRoll(); // diceroll function

                bool validYN = false;
                while (!validYN)
                {
                    Console.Write("Continue? (y/n) ");
                    string yn = Console.ReadLine().ToLower();

                    if (yn != "y" && yn != "n")
                    {
                        Console.WriteLine("Please enter 'y' or 'n' to continue or quit.");
                    }
                    else
                    {
                        validYN = true;
                        if (yn == "n")
                        {
                            cont = false;
                            Console.WriteLine("Thank you for playing!");
                        }
                    }
                }
            }
        }
    }
}
