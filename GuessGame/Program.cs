using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess;
            int answer = 42;

            Console.Write("Enter a number between 1 and 100 to guess the answer: ");

            guess = Convert.ToInt32(Console.ReadLine());

            while (guess != answer)
            {

                if (guess < 1 || guess > 100)
                {
                    Console.WriteLine("Please enter a number between 1 and 100");
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

                Console.Write("Enter a number between 1 and 100 to guess the answer: ");

                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == answer)
                {
                    break;
                }
            }
            Console.WriteLine("Correct");

        }
    }
}
