using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        Address A1 = new Address(23, "Taco Rd", "Rexburg", "Idaho", "USA");
        Address A2 = new Address(3006, "Red Oak Blvd", "Dallas", "Texas", "USA");
        Address A3 = new Address(742, "Evergreen Terrace", "Springfield", "Oregon", "USA");


        Lecture L = new Lecture("How to milk a cow", 
        "In this lecture, Old Mcdonald will explain how milk is formed by cows and then how to extract it using the oldfashioned cow-milking method",
        "July 14th 2026", 1900, A1, "Old McDonald", 3000);

        Reception R = new Reception("Birthday party for Baby Bear", 
        "It's Baby Bear's birthday and Grandma Wolf is throwing a party for the Three Bears and any friends they want to invite!",
        "September 14th, 2026", 1500, A2, "Gwolf1954@cooking.gov");

        OutdoorGathering O = new OutdoorGathering("Homer Simpson's Monorail Party!",
        "Springfield has been blessed by an eccentric businessman who wants to build a monorail for everyone to enjoy, and Homer Simpson wants to make the most of it. Come join him for a fantastic party at his home in Springfield!",
        "October 25, 2027", 1700, A3, "Sunny with a slight chance of rain");

        L.DisplayStandardDetails();
        Console.WriteLine(); Console.WriteLine();
        L.DisplayFullDetails();
        Console.WriteLine(); Console.WriteLine();
        L.DisplayShortDescription();
        Console.WriteLine(); Console.WriteLine();

        R.DisplayStandardDetails();
        Console.WriteLine(); Console.WriteLine();
        R.DisplayFullDetails();
        Console.WriteLine(); Console.WriteLine();
        R.DisplayShortDescription();
        Console.WriteLine(); Console.WriteLine();

        O.DisplayStandardDetails();
        Console.WriteLine(); Console.WriteLine();
        O.DisplayFullDetails();
        Console.WriteLine(); Console.WriteLine();
        O.DisplayShortDescription();
        Console.WriteLine(); Console.WriteLine();

    }
}