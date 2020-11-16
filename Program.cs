using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Moto!");
            Random r = new Random();
            int secretNumber = r.Next(1, 101);
            int chance = 0;
            int chances = Level();
            Guess(chance, chances, secretNumber);
        }

        static int Level()
        {
            int value = 0;
            while (value == 0)
            {
                Console.Write("Select your difficulty! (Hard/Medium/Easy/Cheater): ");
                string selection = Console.ReadLine().ToLower();
                switch (selection)
                {
                    case ("hard"):
                        value = 4;
                        break;
                    case ("medium"):
                        value = 6;
                        break;
                    case ("easy"):
                        value = 8;
                        break;
                    case ("cheater"):
                        value = 10;
                        break;
                    default:
                        Console.WriteLine("Not a valid option.");
                        value = 0;
                        break;
                }
            }
            return value;
        }
        static void Guess(int chance, int chances, int secretNumber)
        {

            while (chance < chances)
            {
                Console.WriteLine($"Chances remaining: {chances - chance}");
                Console.Write("Guess a number: ");
                string input = Console.ReadLine();
                int number;
                if (Int32.TryParse(input, out number))
                {
                    if (chances < 9) { chance++; }
                    if (number == secretNumber)
                    {
                        Console.WriteLine($"You got it! It was {secretNumber}");
                        break;
                    }
                    else
                    {
                        if (number < secretNumber) { Console.WriteLine("Your guess was too low!"); }
                        else { Console.WriteLine("Your guess was too High!"); }
                        if (chances - chance == 0) { Console.WriteLine($"The number was {secretNumber}"); }
                    }

                }
                else
                {
                    Console.WriteLine("Not a valid number!");
                    Guess(chance, chances, secretNumber);
                }


            }

        }
    }
}
