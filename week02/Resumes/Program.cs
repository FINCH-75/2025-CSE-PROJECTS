using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.__jobTitle = "Power Production Specialist Trainee";
        job1._startYear = 2015;
        job1._endYear = 2016;
       
        Job job2 = new Job();
        job2.__jobTitle = "Power Production Specialist 1";
        job2._startYear = 2016;
        job2._endYear = 2019;

        Job job3 = new Job();
        job3.__jobTitle = "Power Production Specialist 2";
        job3._startYear = 2019;
        job3._endYear = 2023;

        Job job4 = new Job();
        job4.__jobTitle = "Assistant Control Room Operator";
        job4._startYear = 2023;
        job4._endYear = 2024;

        Job job5 = new Job();
        job5.__jobTitle = "Control Room Operator";
        job5._startYear = 2024;
        job5._endYear = 2025;
        
        Resume resume = new Resume();
        resume._firstName = "William";
        resume._middleName = "Chad";
        resume._lastName = "Finch";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume._jobs.Add(job3);
        resume._jobs.Add(job4);
        resume._jobs.Add(job5);
        resume.Display();
        
       
    }

    
}


