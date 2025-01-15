using System;
using System.Security.Cryptography.X509Certificates;

class Resume
{
    public string _firstName;
    public string _middleName;
    public string _lastName;

 public List<Job> _jobs = new List<Job>();   
public void Display()
{

    Console.WriteLine($"NAME: {_firstName} {_middleName} {_lastName}");
    Console.WriteLine("Experience:");

    foreach (Job job in _jobs)
        {
            job.Display();
        }

}

}
    
