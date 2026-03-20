using System;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        string ans = "";
        int x = 5;
        bool isDone;


        string scripToAdd = "For God so loved the world, that He gave His only begotten Son, that whosoever believeth in him should not perish, but have everlasting life";
        string scripToAdd2 = "And Paul, as his manner was, went in unto them, and three sabbath days reasoned with them out of the scriptures, Opening and alleging, that Christ must needs have suffered, and risen again from the dead; and that this Jesus, whom I preach unto you, is Christ.";

        Scripture s1 = new Scripture(scripToAdd);
        Scripture s2 = new Scripture(scripToAdd2);
        Reference r1 = new Reference("John", 3, 16);
        Reference r2 = new Reference("Acts", 17, "2-3");
        
        string originalScripture1 = s1.GetScripture();
        
        string ref1 = r1.GetReference();
        string ref2 = r2.GetReference();
        s1.SplitScripture();
        s2.SplitScripture();

        
        
        Console.WriteLine("Hit enter to start, or type quit to quit");
        ans = Console.ReadLine();


        if(ans != "quit")
        {
            
        do
        {
            
            if(x == 5)
            {
                Console.Clear();
                Console.WriteLine($"{originalScripture1}: {ref1}");
            }
            ans = Console.ReadLine();
            Console.Clear();
            string scrip1 = s1.HideWords(x, out isDone);
            x--;
            string t1 = $"{scrip1}: {ref1}";
            Console.WriteLine(t1);
            
            

        }while(ans != "quit" && isDone != true);
        
        }
        else
        {
            Console.WriteLine("Program quit by user");
            return;
        }

        Console.ReadLine();
        Console.Clear();
        string tO = $"{originalScripture1}: {ref1}";
        Console.WriteLine(tO);


        



        



    }
}