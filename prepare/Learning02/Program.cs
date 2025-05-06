using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "BYUI-Idaho";
        job1._jobTitle = "Janitor";
        job1._startYear = 2021;
        job1._endYear = 2023;
        job1.Display();

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2023;
        job2._endYear = 2025;
        job2.Display();

        Resume resume1 = new Resume();
        resume1._name = "Raquel Miller";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
    }
   /* class Applicant 
    {
    public string _firstName;
    public string _lastName;

    public string _phoneNumber;
    public string _emailAddress;

    public int _orderofApplication;
    public int _rank;

    public Resume _resume; //You're making your own data type, so you can call the previous class

    public void Display() 
        {

        }
    }*/
}