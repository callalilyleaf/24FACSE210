using System;

class Program
{
    private static string response;

    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture();
        Reference reference2 = new Reference();
        Console.Clear();
        Console.WriteLine($"{reference2.GetReference()}\n{reference2.GetVerse()}");
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
        response = Console.ReadLine().ToLower();
        scripture1.setAvaliableIndex();
        
        while (response != "QUIT" & scripture1.Status() != true) // How? What's the logic behind using & ??
        {   
            if (response == "")
            {
                Console.Clear();
                scripture1.DisplayScripture();
                Console.WriteLine("\nPress enter to continue, type 'r' to reveal all the hidden scripture words, or type 'quit' to finish: ");
                response = Console.ReadLine().ToLower();
            }
            else if (response == "r")
            {
                Console.Clear();
                scripture1.RevealHiddenWords();
                Console.WriteLine("\nPress enter to continue, type 'r' to reveal all the hidden scripture words, or type 'quit' to finish: ");
                response = Console.ReadLine().ToLower();
            }
        }
        Console.Clear();

    }
}