using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        
        Assignment assignment = new Assignment("Jacob Hanks", "Sales");
        MathAssignment mathAssignment = new MathAssignment("William Afton", "Calculus", "Section 7.1", "Problems 1-10");
        WritingAssignment writingAssignment = new WritingAssignment("Johhny Joestar", "Psychology", "Top ten mental asylums");

        string s = assignment.GetSummary();
        Console.WriteLine(s);

        string s1 = mathAssignment.GetSummary();
        Console.WriteLine(s1);
        string s2 = mathAssignment.GetHomeWorkList();
        Console.WriteLine(s2);

        string s3 = writingAssignment.GetSummary();
        Console.WriteLine(s3);
        string s4 = writingAssignment.GetWritingInformation();
        Console.WriteLine(s4);






    }
}