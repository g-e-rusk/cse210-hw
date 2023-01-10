using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {      
        List<int> numbers = new List<int>();
        
        int userNumber = -1;     

        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string userAnswer = Console.ReadLine();
            userNumber = int.Parse(userAnswer);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            

        }

        //int total = numbers.Sum();
        //Console.Out.WriteLine($"The sum is: {total}");

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        //double avg = Queryable.Average(numbers.AsQueryable());
        //Console.WriteLine("The average is: " +avg);

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //int max = numbers.Max();
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}