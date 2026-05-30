using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        Console.WriteLine();



        Video V1 = new Video("Eating 10,000 tacos in one day!", "BarbieIRLWorld", 500);
        Comment V1C1 = new Comment("BigPlayer300", "I really liked this video, too bad he only got to eat 7000 tacos");
        Comment V1C2 = new Comment("Ragebaiter67", "Bro 10000 tacos is light work I could do that in my sleep do something harder next time");
        Comment V1C3 = new Comment("KujoJotaro", "Great video, 10/10 experience, would watch again");

        V1.AddComment(V1C1);
        V1.AddComment(V1C2);
        V1.AddComment(V1C3);

        Video V2 = new Video("How many monkeys does it take to build a lightbulb?", "Vsauce", 400);
        Comment V2C1 = new Comment("IdahoMan","I think monkeys are too talented for this experiment, you should try it with cows or something dumber next time");
        Comment V2C2 = new Comment("Tacoman35","Those monkeys would look a lot better if instead of making a lightbulb they were making tacos");
        Comment V2C3 = new Comment("Aristotle", "I think it would be better to give them a typewriter and see how long it takes for them to write something coherent");
        Comment V2C4 = new Comment("C. Montgomery Burns", "@Aristotle, I tried that once. They couldn't even write that it was the worst of times instead of writing the blurst of times. Stupid monkeys");

        V2.AddComment(V2C1);
        V2.AddComment(V2C2);
        V2.AddComment(V2C3);
        V2.AddComment(V2C4);

        Video V3 = new Video("Is Bigfoot really Cain? Exploring the Amazon with Chris Hemsworth", "WhiteHouseOfficial", 20000);
        Comment V3C1 = new Comment("Noobmaster69", "Chris Hemsworth is not good at Fortnite");
        Comment V3C2 = new Comment("ThomasJefferson", "I appreciated this video a lot, Chris does a great job of explaining why Bigfoot could not have possibly been an Amazonian woman");
        Comment V3C3 = new Comment("Notbigfoot", "I think you guys are onto something, Bigfoot is definitely in the Amazon and you should only look for him there"); 

        V3.AddComment(V3C1);
        V3.AddComment(V3C2);
        V3.AddComment(V3C3);

        List<Video> videos = new List<Video>{V1, V2, V3};


        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}