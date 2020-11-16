using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Moto!");
            Random r = new Random();
            int secretNumber = r.Next(1, 100);
            int chance = 0;
            int chances = Level();
            Guess(chance, chances, secretNumber);
        }

        static int Level()
        {
            Console.Write("Select your difficulty! (Hard/Medium/Easy/Cheater): ");
            string selection = Console.ReadLine();
            int value = 8;
            if (selection.ToLower() == "hard") { value = 4; return value; }
            else if (selection.ToLower() == "medium") { value = 6; return value; }
            else if (selection.ToLower() == "easy") { value = 8; return value; }
            else if (selection.ToLower() == "cheater") { value = 10; return value; }
            else
            {
                Console.WriteLine("Not a valid option.");
                return Level();
            }
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

                    // Console.WriteLine($"Your number: {number}");
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
