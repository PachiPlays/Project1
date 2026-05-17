using System;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

                
        BreathingActivity B1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by giving you prompts on when to breathe out and in! Prepare and focus on your breathing.");
        ReflectionActivity R1 = new ReflectionActivity("Reflection Activity", "This activity will help you think about your past and reflect on times that you have shown strength. It will help you focus on the inner power that you have and strengths that you might have forgotten.");
        ListingActivity L1 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things you have in your life by asking you to list things in a certain area");
        int selectedActivity = DisplayMenu();


        switch (selectedActivity)
        {
            case 1:
            B1.DisplayStartingPrompt();
            B1.DisplayLoadingIcon(7);
            int x = B1.GetLength();
            B1.BeginActivity(x);
            B1.DisplayEndingPrompt();
            break;

            case 2:
            R1.DisplayStartingPrompt();
            R1.DisplayLoadingIcon(7);
            int y = R1.GetLength();
            R1.DisplayRandomPrompt();
            R1.DisplayQuestions(y);
            R1.DisplayEndingPrompt();
            break;

            case 3:
            L1.DisplayStartingPrompt();
            L1.DisplayLoadingIcon(7);
            int z = L1.GetLength();
            L1.DisplayPrompt(z);
            L1.DisplayUserEntries();
            L1.DisplayEndingPrompt();
            break;

            default:
            Console.WriteLine("That's not a valid entry, please try again!");
            break;
        }


 
 
    }

    static int DisplayMenu()
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("Please select your desired activity:");
        Console.WriteLine("1: Breathing Activity");
        Console.WriteLine("2: Reflection Activity");
        Console.WriteLine("3: Listing Activity");
        int x = int.Parse(Console.ReadLine());
        return x;
    }
}