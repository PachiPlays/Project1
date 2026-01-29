

public class Job
{
    //public string GetDescription();
}


public class Education
{
    public string _school;

    public string GetDescription()
    {
        return $"Educationn with school: {_school}";
    }
}

public class Resume
{
    public string _name;

    public List<Job> _jobs = new List<Job>();
    public List<Education> _experience;


    public void DisplayFullResume()
    {
        Console.WriteLine($"Resume for {_name}");

        foreach(Job job in _jobs)
        {
           // string desc = job.GetDescription();
           // Console.WriteLine($"   {desc}");
        }
    }
}
