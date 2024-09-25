using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
       
       Console.Write("What is your grade percentage? ");
       float grade_perc = float.Parse(Console.ReadLine());
       string grade_level = "";
    
       if (grade_perc >= 90)
       {
        grade_level = "A";
       } 

       else if (grade_perc >= 80 && grade_perc < 90)
       {
        grade_level = "B";
       }

       else if  (grade_perc >= 70 && grade_perc < 80)
       {
        grade_level = "C";
       }

       else if (grade_perc >= 60 && grade_perc < 70)
       {
        grade_level = "D";
       }

       else if (grade_perc < 60)
       {
        grade_level = "F";
       }

       Console.WriteLine($"Your grade is {grade_level}");
       
       if (grade_perc >= 70)
       {
        Console.WriteLine("Congratulation! You passed this class.");
       }

       else
       {
        Console.WriteLine("You will do better next time!");
       }

    }
}