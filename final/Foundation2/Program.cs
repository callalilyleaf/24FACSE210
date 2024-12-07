using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order(0);
        Order order2 = new Order(1);

        order1.GetShippingLabel();
        order1.GetPackingLabel();
        order1.CalTotalCost();
        Console.WriteLine($"Total Price: {order1.GetTotalCost()}");
        Console.WriteLine(new string('-', 50));
        
        order2.GetShippingLabel();
        order2.GetPackingLabel();
        order2.CalTotalCost();
        Console.WriteLine($"Total Price: {order2.GetTotalCost()}");

    }
}