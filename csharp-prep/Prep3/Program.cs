using System;
using System.Net;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
    string response = "";

    while (response != "N")
    {
        Random randomGenerator = new Random();
        int int_answer = randomGenerator.Next(1, 1024);
        
        int int_guess = -1;
        int count = 0;

        do
        {
            Console.WriteLine("What is your guess? ");
            string str_guess = Console.ReadLine();
            count++ ;
            int_guess = int.Parse(str_guess);
        
            if (int_guess > int_answer)
            {
                Console.WriteLine("Guess Lower!");
            }

            else if (int_guess < int_answer)
            {
                Console.WriteLine("Guess higher!");
            }

            else
            {
                Console.WriteLine($"You got it! You used '{count}' times to get it!");
            }

        } while (int_guess != int_answer);
    Console.WriteLine("Do you want to play again? (Y/N)");
    response = Console.ReadLine();
    }
    

    }

}