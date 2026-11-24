using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();
        Job1._company = "Microsoft";
        Job1._jobTitle = "Customer Service Representative";
        Job1._startYear = 1995;
        Job1._endYear = 2008;

        Job Job2 = new Job();
        Job2._company = "Steam";
        Job2._jobTitle = "Customer Support Manager";
        Job2._startYear = 2009;
        Job2._endYear = 2025;

        Job1.Display();
        Job2.Display();

        Resume myResume = new Resume();

        myResume._name = "Vance Wayne";
        myResume._jobs.Add(Job1);
        myResume._jobs.Add(Job2);
        Console.WriteLine(myResume._jobs[0]._jobTitle);

        myResume.Display();
    }
}