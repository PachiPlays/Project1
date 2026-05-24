using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Quest Program!");

        int userInput = 0;

        
        
        
        GoalTracker G1 = new GoalTracker();



        while (userInput != 6){
        
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List goals");
        Console.WriteLine("3. Save goals");
        Console.WriteLine("4. Load goals");
        Console.WriteLine("5. Record event");
        Console.WriteLine("6. Quit program");

        G1.DisplayPoints();

        userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                int x = int.Parse(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                        SimpleGoal S1 = new SimpleGoal();
                        S1.GetGoalInfo();
                        G1.AddGoal(S1);
                        break;

                        case 2:
                        EternalGoal E1 = new EternalGoal();
                        E1.GetGoalInfo();
                        G1.AddGoal(E1); 
                        break;

                        case 3:
                        CheckListGoal C1 = new CheckListGoal();
                        C1.GetGoalInfo();
                        G1.AddGoal(C1);
                        break;
                    }
                break;

                case 2:
                G1.DisplayGoals();
                break;

                case 3:
                G1.SaveFile();
                break;

                case 4:
                Console.WriteLine("What is the name of your file?");
                string filename = Console.ReadLine();
                G1.LoadFile(filename);
                break;

                case 5:
                Console.WriteLine("Which goal did you complete?");
                G1.DisplayGoals();
                int y = int.Parse(Console.ReadLine());
                G1.MarkComplete(y - 1);
                G1.DisplayPoints();
                break;

                case 6:
                Console.WriteLine("Have a great day!");
                break;

                default:
                Console.WriteLine("That's not a valid entry! Please try again");
                break;
            }

        }

    }
}