using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            int sNumber = new Random().Next(1, 100);
            int numOfGuesses = 4;
            int level = 0;

            Console.WriteLine("Guess the secret number");
            Console.WriteLine($"{sNumber}");
            Console.WriteLine("Choose a difficulty 1, 2 or 3");
            while (level == 0)
            {
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        level = 1;
                        numOfGuesses = 8;
                        Console.WriteLine("8 guesses left! Good luck!");
                        break;

                    case 2:
                        level = 2;
                        numOfGuesses = 6;
                        Console.WriteLine("6 guesses left! Good luck!");
                        break;

                    case 3:
                        level = 3;
                        numOfGuesses = 4;
                        Console.WriteLine("4 guesses left! Good luck!");
                        break;

                    case 4:
                        level = 4;
                        numOfGuesses = 99;
                        Console.WriteLine("99 guesses left! Good luck!");
                        break;

                    default:
                        Console.WriteLine("Choose your difficulty: 1, 2 or 3");
                        break;
                }
            }

            int answer = int.Parse(Console.ReadLine());

            while (numOfGuesses > 1)
            {
                string highString = "too high! Try again!";

                if (answer < sNumber)
                {
                    highString = "too low! Try again!";
                }
                if (answer == sNumber)
                {
                    Console.WriteLine("Your answer is right on the money! Great job!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Your guess was {highString}. You have {numOfGuesses - 1} guesses left!");
                }
                if (numOfGuesses != 99)
                {
                    numOfGuesses--;
                }
                answer = int.Parse(Console.ReadLine());
            }
        }
    }
}