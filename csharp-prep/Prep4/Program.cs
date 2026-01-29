using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        

        int bigNumber = 0;
        int smallNumber = 100;
        int numberToAdd = -1;

        //make a list of a series of numbers
        List<int> numbers = new List<int>();

        while (numberToAdd != 0)
        {
            
        Console.WriteLine("Enter a number to add: ");

        numberToAdd = int.Parse(Console.ReadLine());
        
        if (numberToAdd != 0)
            {
                numbers.Add(numberToAdd);
            }
        }

        int sum = 0;
        int average = 0;
        int numberOfNumbers = numbers.Count();

        Console.WriteLine("Here is your list!");
        foreach (int number in numbers)
        {
            
            
            sum += number;
            
            average = sum/numberOfNumbers;

            if (number < smallNumber)
            {
                smallNumber = number;
            }

            if (number > bigNumber)
            {
                bigNumber = number;
            }
                

            Console.WriteLine(number);
            
        }
        Console.WriteLine($"This is the sum: {sum}");
        Console.WriteLine($"This is the average: {average}");
        Console.WriteLine($"This is the smallest number: {smallNumber}");
        Console.WriteLine($"This is the biggest number: {bigNumber}");


        
        

    

    }
}