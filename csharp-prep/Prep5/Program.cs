using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;


class Program
{
    static void Main(string[] args)
    {


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Porgram!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        
        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SqaureNumber(int input_num)
        {
            int result = input_num * input_num;
            return result;
        }

        static void Main()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int userNumber = SqaureNumber(PromptUserNumber());
            Console.WriteLine($"{userName}, the square of your numeber is {userNumber}");

        }

        Main();


    }
}