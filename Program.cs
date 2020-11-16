using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Moto!");
            Guess();
        }
        static void Guess()
        {
            Console.Write("Guess a number:");
            string input = Console.ReadLine();
            int number;
            if (Int32.TryParse(input, out number))
            {
                number = Convert.ToInt32(input);
                Console.WriteLine($"Your number: {number}");
            }
            else
            {
                Console.WriteLine("Not a valid number!");
                Guess();
            }

        }
    }
}
