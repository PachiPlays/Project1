public class Job
        {
            public string _jobTitle = "";
            public string _companyName = "";
            public int _startYear = 0;
            public int _endYear = 0;

            public void DisplayJob()
        {
            Console.WriteLine($"{_jobTitle} at {_companyName}");
            Console.WriteLine($"{_startYear}-{_endYear}");
        }


        }