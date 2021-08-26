using System;
using System.Collections.Generic;
using System.Linq;


namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;

            Console.Write("Do you know what the secret number is? Guess: ");
            string answer = Console.ReadLine().ToLower();

            if (secretNumber == int.Parse(answer))
            {
                Console.WriteLine("You guessed it!!");
            }
            else
            {
                Console.WriteLine("Incorrect! Try again.");
            }
        }
    }
}

