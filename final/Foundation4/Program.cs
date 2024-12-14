using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("03 Nov 2022", 30, 3.0);
        Cycling cycling = new Cycling("04 Nov 2022", 45, 9.6);
        Swimming swimming = new Swimming("05 Nov 2022", 75, 50);

        running.Calculate();
        cycling.Calculate();
        swimming.Calculate();

        running.PrintSummary();
        cycling.PrintSummary();
        swimming.PrintSummary();
    }
}