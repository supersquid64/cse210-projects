using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your current grage percentage? ");
        int gradenum = Convert.ToInt32(Console.ReadLine());
        string grademod = "";
        string gradelet = "";
        if (gradenum < 90 && gradenum >=60 && gradenum % 10 < 3)
        {
            grademod = "-";
        }
        else if (gradenum < 90 && gradenum >=60 && gradenum % 10 >=7)
        {
            grademod = "+";
        }

        if (gradenum >= 90)
        {
            gradelet = "A";
        }
        else if (gradenum >= 80)
        {
            gradelet = "B";
        }
        else if (gradenum >= 70)
        {
            gradelet = "C";
        }
        else if (gradenum >= 60)
        {
            gradelet = "D";
        }
        else if (gradenum < 60)
        {
            gradelet = "F";
        }

        Console.Write($"Your grade will be {gradelet}{grademod}");
    }
}