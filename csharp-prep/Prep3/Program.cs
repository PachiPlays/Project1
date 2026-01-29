using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random numberGenerator = new Random();
        int number = numberGenerator.Next(1, 100);
        
        string response = "-2";
        while (int.Parse(response) != number)
        {
            Console.Write("What do you think the number is? ");
            response = Console.ReadLine();

            if (int.Parse(response) != number)
            {
                Console.WriteLine("That's not right!");
            }

            if (int.Parse(response) < number)
            {
                Console.WriteLine("It should be higher!");
            }

            if (int.Parse(response) > number)
            {
                Console.WriteLine("It should be lower!");
            }
        }
        


        Console.WriteLine("You got it!");



    }
}