using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");


        Fraction fraction = new Fraction();

        Fraction fraction1 = new Fraction(5);
        
        Fraction fraction2 = new Fraction(6, 7);

        for (int i = 0; i < 20; i++)
        {
            Random random = new Random();
            int top = random.Next(1, 10);
            int bottom = random.Next(1, 10);

            fraction.SetTop(top);
            fraction.SetBottom(bottom);

            string str = fraction.GetFractionString();
            double dub = fraction.GetDecimalValue();

            string total = $"Fraction {i+1} = string: {str} // decimal: {dub}";

            Console.WriteLine(total);

        }

        /*fraction.SetTop(2);

        int f1 = fraction.GetTop();
        Console.WriteLine(f1);
        int f2 = fraction.GetBottom();
        Console.WriteLine(f2);

        string f3 = fraction.GetFractionString();
        Console.WriteLine(f3);

        double dec = fraction2.GetDecimalValue();
        Console.WriteLine(dec);*/

        
    }
}