using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("742 Maple Street", "Springfield", "Illinois", "USA");
        Address address2 = new Address("389 Elm Road", "Burlington", "Vermont", "USA");
        Address address3 = new Address("Chapelle des Expiatoires, 29 Rue Pasquier", "Paris", "Île-de-France", "France");
        
        Outdoor outdoor = new Outdoor("Springfield Summer Fest", "A vibrant community celebration featuring local food vendors, live music, and family-friendly activities in the heart of Springfield.", "Saturday, July 20, 2024", "4:00 PM - 9:00 PM",address1, "Partly cloudy with temperatures around 78°F, light breeze, perfect for an evening outdoor gathering.");

        Lecture lecture = new Lecture("Climate Change and Local Ecosystems", "A comprehensive exploration of environmental challenges and sustainable solutions in the Northeast, focusing on Vermont's unique ecological landscape.", "Thursday, September 12, 2024", "7:00 PM - 8:30 PM", address2,"Dr. Elizabeth Harrington, Environmental Science Professor at University of Vermont", 150);

        Reception reception = new Reception("Parisian Artistic Heritage Gala", "An elegant evening celebrating international art collaborations, featuring curated exhibitions and networking opportunities for cultural professionals.", "Friday, October 5, 2024", "7:30 PM - 11:00 PM", address3, "parisianheritageevents@culturalalliance.org");

        Console.WriteLine(new string('-', 50));
        outdoor.PrintStandardDetails();
        outdoor.PrintFullDetails();
        outdoor.PrintShortDescription();
        Console.WriteLine(new string('-', 50));

        Console.WriteLine(new string('-', 50));
        lecture.PrintStandardDetails();
        lecture.PrintFullDetails();
        lecture.PrintShortDescription();
        Console.WriteLine(new string('-', 50));

        Console.WriteLine(new string('-', 50));
        reception.PrintStandardDetails();
        reception.PrintFullDetails();
        reception.PrintShortDescription();
        Console.WriteLine(new string('-', 50));
    }
}
