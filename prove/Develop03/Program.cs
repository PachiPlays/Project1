class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        string userInput;

        Reference R1 = new Reference("John", 3, 16);
        Scripture S1 = new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life", R1);

        Reference R2 = new Reference("Proverbs", 3, 5, 6);
        Scripture S2 = new Scripture("Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.", R2);

        List<Scripture> scriptures = new List<Scripture>{S1, S2};

        int x = Random.Shared.Next(0, 2);   
        Scripture SX = scriptures[x];     

        Console.Clear();
        SX.DisplayScripture();
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        userInput = Console.ReadLine();

        while(userInput != "quit")
        {
            Console.Clear();
            SX.DisplayScriptureWithHiddenWords();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            int z = SX.GetNumberOfHiddenWords();
            if (z == 0)
            {
                break;
            }
            userInput = Console.ReadLine();
            if (userInput == "quit")
            {
                break;
            }



        }

        

        



        



    }
}