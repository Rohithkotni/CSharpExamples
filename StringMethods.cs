using System;

namespace Examples
{
    public class StringMethods
    {
        public static void Methods()
        {
            Console.Write("Enter the string here: ");
            //Read first input string.
            string input = Console.ReadLine();
            Console.Write("Enter a Character to search: ");
            //Read the character input to search.
            char searchInput = Console.ReadLine()[0];
            //Gets the Index of the character from the string.
            int searchIndex = input.IndexOf(searchInput);
            //Prints the Index as a search result on console.
            Console.WriteLine("Index of character {0} in string is {1}", searchInput, searchIndex);
            //Prints Trimmed values like trimming whitespaces or characters based on limit
            Console.WriteLine($"Value of {input} after trimming first 2 characters is{input.Trim()}");
            //Prints values starting from a specific position based on give value
            Console.WriteLine($"Substring Value of {input} starting After 2 positions is {input.Substring(2)}");

        }
    }
}

