using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess= 1;
            int answer = 42;

            Console.Write("Enter a number between 1 and 100 to guess the answer: ");

            try
            {
                guess = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.Write("Please enter a number; ");
            }

            while (guess != answer)
            {
                try
                {
                    if (guess < 1 || guess > 100)
                    {
                        Console.WriteLine("Please enter a number between 1 and 100");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect \n");
                    }

                    Console.Write("Enter a number between 1 and 100 to guess the answer: ");

                    guess = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Write("Please enter a number; ");
                }


                if (guess == answer)
                {
                    break;
                }
            }
            Console.WriteLine("Correct");

        }
    }
}
