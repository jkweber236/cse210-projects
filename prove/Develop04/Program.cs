using System;

class Program 
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity("Breathing", "This activity will help you relax by walking you through "
        + "breathing in and out slowly. Clear your mind and focus on your breathing.");

        ReflectingActivity reflecting = new ReflectingActivity("Reflecting", "This activitiy will help you reflect on times in your "
        + "life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it " 
        + "in other aspects of your life.");

        ListingActivity listing = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life "
        + "by having you list as many things as you can in a certain area.");

        string user_input = "";
        int breathingLog = 0;
        int reflectingLog = 0;
        int listingLog = 0;

        while (user_input != "5")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Display activity log");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");

            user_input = Console.ReadLine();

            if (user_input == "1")
            {
                breathing.RunActivity();
                breathingLog += 1;
            }

             else if (user_input == "2")
            {
                reflecting.RunActivity();
                reflectingLog += 1;
            }

            else if (user_input == "3")
            {
                listing.RunActivity();
                listingLog += 1;
            }

            else if (user_input == "4")
            {
                ActivityLog activityLog = new ActivityLog("Activity Log", "Log of the number of times " 
                + "each activity was performed.", + breathingLog, reflectingLog, listingLog);

                activityLog.RunActivity();
            }
        }
    }
}