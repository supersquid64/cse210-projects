using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is favorite number? ");
        string numstring = Console.ReadLine();
        int favenum = Convert.ToInt32(numstring);
        return favenum;
        
    }
    static void PromtUserBirthYear(out int birthyear)
    {
        Console.Write("What is birth year? ");
        string yearstring = Console.ReadLine();
        birthyear = Convert.ToInt32(yearstring);
    }
    static int SquareNumber(int x)
    {
        int numsquare = x * x;
        return numsquare;
    }
    static void DisplayResult(string name,int square,int birth)
    {
        int currentyear = DateTime.Now.Year;
        int age = currentyear - birth;
        Console.WriteLine($"{name}, your favorite number squared is {square} and you will or have become {age} years old this year.");
    }
    static void Main(string[] args)
    {
        int birthyear;
        DisplayWelcome();
        string name = PromptUserName();
        int favenum = PromptUserNumber();
        PromtUserBirthYear(out birthyear);
        int numsquare = SquareNumber(favenum);
        DisplayResult(name, numsquare, birthyear);
    }
}