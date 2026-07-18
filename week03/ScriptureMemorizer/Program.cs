using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        

        List<Scripture> library = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference(" Matthew", 5, 9), "Blessed are the peace makers for they shall be called the Sons of God."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."),
            new Scripture(new Reference("2Nephi", 5, 17), "And it came to pass that I, Nephi, did make plates of ore that I might engraven upon them the record of my people.")
        };

        Random random = new Random();
        Scripture scripture = library[random.Next(library.Count)];

        string userInput = "";

        while (userInput.ToLower()!= "quit" &&!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            if (userInput.ToLower()!= "quit")
            {
                scripture.HideRandomWords(3); // hide 3 words each time
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words have been hidden. Good job memorizing!");
    }
}