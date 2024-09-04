using System;
using System.IO;
using System.Linq;

public static class FileAnalyzer
{
    public static void GetSymbolsCountInEachLine()
    {
        string[] lines = File.ReadAllLines("client.test.js");
        foreach (string line in lines)
        {
            Console.WriteLine(line.Length);
        }
    }

    public static string GetLongestLine()
    {
        string[] lines = File.ReadAllLines("client.test.js");
        return lines.OrderByDescending(line => line.Length).FirstOrDefault();
    }

    public static string GetShortestLine()
    {
        string[] lines = File.ReadAllLines("client.test.js");
        return lines.OrderBy(line => line.Length).FirstOrDefault();
    }

    public static string[] GetLinesWithLet()
    {
        string[] lines = File.ReadAllLines("client.test.js");
        return lines.Where(line => line.Contains("let")).ToArray();
    }

    public static void Main()
    {
        GetSymbolsCountInEachLine();
        Console.WriteLine($"Longest line: {GetLongestLine()}");
        Console.WriteLine($"Shortest line: {GetShortestLine()}");
        Console.WriteLine("Lines with 'let':");
        foreach (var line in GetLinesWithLet())
        {
            Console.WriteLine(line);
        }
    }
}
