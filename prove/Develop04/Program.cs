using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

// Stretches:
// 1. No duplicated prompts in reflection activity
// 2. Handle the invalid menu input from the user

// Errors:
// 1. The breathing activity: finished
// 2. The reflection activity: finished
// 3. The Listing activity: finished
public partial class Program
{   
    private static bool isFinished = false;
    private static int _response;
    private static string _menu = @"Welcome to Mindfullness activities!
    Menu Options:
        1. Start Breathing activity
        2. Start Reflecting activity
        3. Start Listing activity
        4. Quit
    Select a choice from the menu: ";
    static void Main(string[] args)
    {
        while (!isFinished)
        {   
            Console.Clear();
            Console.Write(_menu);

            if (int.TryParse(Console.ReadLine(), out int number) && number >=1 && number <= 4)
            {
                _response = number;
                if (_response == 1)
                {   
                    Console.Clear();
                    Breathing breath = new Breathing();
                    breath.WelcomeMessage();
                    breath.GetTime();
                    breath.BreathInOut(); 
                    breath.EndMessage();
                    Console.Clear();
                }
                else if (_response == 2)
                {   
                    Console.Clear();
                    Reflection reflection = new Reflection();
                    reflection.WelcomeMessage();
                    reflection.GetTime();
                    reflection.PreReflect();
                    reflection.Reflect();
                    reflection.EndMessage();
                    Console.Clear();
                }
                else if (_response == 3)
                {   
                    Console.Clear();
                    Listing listing = new Listing();
                    listing.WelcomeMessage();
                    listing.GetTime();
                    listing.ListingAnswers();
                    listing.EndMessage();
                    Console.Clear();
                    // invoke listing activity
                }
                else if (_response == 4)
                {   
                    // Quit the program
                    Console.WriteLine("See ya next time. Have a good one! :) ");
                    Thread.Sleep(2000);
                    Console.Clear();
                    isFinished = true;
                    
                };
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

        }
    }

}

