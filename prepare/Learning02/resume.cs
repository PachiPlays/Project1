using System.ComponentModel.DataAnnotations;

public class Resume
{
    
    public string _nameOfPerson = "";
    public List<Job> _listOfJobs = new List<Job>();


    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_nameOfPerson}");
        //Console.WriteLine($"{}")
        Console.WriteLine("Jobs: ");

        foreach (Job j in _listOfJobs)
        {
            j.DisplayJob();
        }
/*
        Job job1 = _listOfJobs[0];
        job1.DisplayJob();
        Job job2 = _listOfJobs[1];
        job2.DisplayJob();
*/
    }



}