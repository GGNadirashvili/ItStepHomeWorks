using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = @"C:\Program Files";
        PrintDirectoryContents(path);
    }

    static void PrintDirectoryContents(string path)
    {
        try
        {
            Console.WriteLine($"Directory: {path}");

            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                Console.WriteLine($"File: {file}");
            }

            string[] subDirectories = Directory.GetDirectories(path);
            foreach (string subDirectory in subDirectories)
            {
                PrintDirectoryContents(subDirectory);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
