using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();

        int percentage = int.Parse(grade);

        if (percentage >= 90)
        {
            Console.WriteLine("Distinction!");
        }

        else if (percentage >= 80)
        {
            Console.WriteLine("Proficient!");
        }

        else if (percentage >= 70)
        {
            Console.WriteLine("Satisfactory!");
        }

        else if (percentage >= 60)
        {
            Console.WriteLine("Pass!");
        }

        else if (percentage < 60)
        {
            Console.WriteLine("Fail!");
        }
    }
}