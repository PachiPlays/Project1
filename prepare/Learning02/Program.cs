using System;

class Program
{
    static void Main(string[] args)
    {

    
     Job job1 = new Job();
     Job job2 = new Job();

    job1._companyName = "Duff Beer";
    job1._jobTitle = "Duffman";
    job1._startYear = 2019;
    job1._endYear = 2020;

    //job1.DisplayJob();

    job2._companyName = "Springfield Nuclear Power Plant";
    job2._jobTitle = "Safety Inspector";
    job2._startYear = 1989;
    job2._endYear = 2026;
    
    


    Resume resume1 = new Resume();

    resume1._listOfJobs.Add(job1);
    resume1._listOfJobs.Add(job2);
    
    resume1._nameOfPerson = "Homer Simpson";
    
    resume1.DisplayResume();

    

    

        
    }
    
        

    

           
    
    
}