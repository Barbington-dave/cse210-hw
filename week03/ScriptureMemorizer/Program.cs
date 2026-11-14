using System;

// Exceeding Requirements Report:
// - Implemented the stretch challenge to randomly select only from words that 
//   are not already hidden, ensuring each hide action targets unique visible words.
// - Provided multiple constructors in the Reference class for both single verses 
//   and verse ranges (Proverbs 3:5-6).
class Program
{
    static void Main(string[] args)
    {
        
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        
        
        Scripture scripture = new Scripture(
            reference, 
            "Trust in the Lord with all thine heart and lean not unto thine own understanding"
        );

        string userInput = "";

        
        while (userInput != "quit")
        {
           
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine()?.Trim().ToLower();

            if (userInput != "quit")
            {
               
                scripture.HideRandomWords(3);
            }
        }

        Console.WriteLine("\nProgram ended. Good job memorizing!");
    }
}