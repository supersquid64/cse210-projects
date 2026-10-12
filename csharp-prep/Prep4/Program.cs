using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int mynumber = 0;
        int numsum = 0;
        int bignum = -2147483648;
        int lilnum = 2147483647;
        string mynumberstring;
        Console.WriteLine("Enter a list of numbers, with 0 as the final number.");
        do
        {
            Console.Write("Enter a number. ");
            mynumberstring = Console.ReadLine();
            mynumber = Convert.ToInt32(mynumberstring);
            numbers.Add(mynumber);
        }while (mynumber != 0);
        foreach (int number in numbers)
        {
            numsum += number;
            if (number > bignum)
            {
                bignum = number;
            }
            if (number < lilnum && number >= 1)
            {
                lilnum = number;
            }
        }

        numbers.Sort();
        int numaverage = numsum/numbers.Count;
        Console.WriteLine($"The sum is {numsum}");
        Console.WriteLine($"The average is {numaverage}");
        Console.WriteLine($"The largest number is {bignum}");
        if (lilnum == 2147483647)
        {
            Console.WriteLine("There is no posotive number to be the smallest.");
        } else {
            Console.WriteLine($"The smallest posotive number is {lilnum}");
        }
        Console.WriteLine("The sorted list is ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}