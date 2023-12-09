using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("101 Pebble Lane", "Phoenix", "Arizona");
        Lecture lecture = new Lecture("Time Management: Strategies for Success", 
        "Join us for an informative lecture on effective time management strategies to enhance productivity and achieve success in your personal and professional life.", 
        "January 10, 2024", "2 PM - 4 PM", lectureAddress, "Samantha Miller", 300);

        Console.WriteLine("-Lecture messages-\n");
        Console.WriteLine("Standard details:");
        lecture.GetStandardDetails();

        Console.WriteLine("Full details:");
        lecture.GetFullDetails();

        Console.WriteLine("Short description:");
        lecture.GetShortDescription();

        Address receptionAddress = new Address("123 Main St", "Reno", "Nevada");
        Reception reception = new Reception("Wedding Reception",
        "Join us for a joyous wedding reception as we celebrate the union of Patrick and Patricia. Revel in an evening of love, laughter, and unforgettable moments.",
        "July 16, 2024", "5 PM - 8 PM", receptionAddress, "johndoe456@gmail.com");

        Console.WriteLine("-Reception messages-\n");
        Console.WriteLine("Standard details:");
        reception.GetStandardDetails();

        Console.WriteLine("Full details:");
        reception.GetFullDetails();

        Console.WriteLine("Short description:");
        reception.GetShortDescription();

        Address outdoorAddress = new Address("409 Lyons Dr", "Nampa", "Idaho");
        OutdoorGathering outdoors = new OutdoorGathering("Family Reunion", 
        "Join us for a picnic in the park! Pack your favorite treats, games, and blankets for a fun-filled day.",
        "August 12, 2024", "10 AM - 3 PM", outdoorAddress, "78° F");

        Console.WriteLine("-Outdoor gathering messages-\n");
        Console.WriteLine("Standard details:");
        outdoors.GetStandardDetails();

        Console.WriteLine("Full details:");
        outdoors.GetFullDetails();

        Console.WriteLine("Short description:");
        outdoors.GetShortDescription();
    }
}