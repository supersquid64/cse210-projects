using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1, 100);
        string guessstring;
        int guess;
        int guessnum = 0;

        do
        {
            Console.Write("Guess the number (1-100) ");
            guessstring = Console.ReadLine();
            guess = Convert.ToInt32(guessstring);
            guessnum ++;
            if (guess > num)
            {
                Console.WriteLine("The number is lower.");
            } else if (guess < num)
            {
                Console.WriteLine("The number is higher.");
            }
        } while (guess != num);
        Console.Write($"Congradulation, you guessed the correct number, it took you {guessnum} tries.");
    }
}