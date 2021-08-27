using System;
using System.Collections.Generic;


namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int sNumber = 42;
            Console.WriteLine("Can you guess the secret number?");
            Console.Write("Write your answer here: ");
            string answer = Console.ReadLine();

            if (sNumber == int.Parse(answer))
            {
                Console.WriteLine("You got it right! Nice!");
            }
            else
            {
                Console.WriteLine("You suck! Try again loser.");
            }

        }
    }
}
