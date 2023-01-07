using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int gradePercent = int.Parse(userInput);
        string letter = "";

        if (gradePercent >= 90)
        {
            letter = "A";
        }

        else if (gradePercent >= 80)
        {
            letter = "B";
        }

        else if (gradePercent >= 70)
        {
            letter = "C";
        }

        else if (gradePercent >= 60)
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else 
        {
            Console.WriteLine("You did not pass the course. Better luck next time.");
        }
    }
}