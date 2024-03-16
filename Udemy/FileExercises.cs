using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class FileExercises
{
    public static void FilesStuff()
    {
        //Challenge 1. Write a program that reads a text file and displays the number of words.
        var path = @"C:\Users\txt.txt";

        var wordNum = new List<string>(File.ReadAllText(path).Split(' '));

        Console.WriteLine(wordNum.Count());

        //Challenge 2. Write a program that reads a text file and displays the longest word in the file.

        int wordLenght = 0;
        var longestWord = "";

        foreach (var word in wordNum)
        {
            if (word.Length > wordLenght)
            {
                longestWord = word;
            }
        }
        Console.WriteLine(longestWord);
    }
}