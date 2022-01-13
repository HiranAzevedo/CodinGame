using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine() ?? "0");
        int y = int.Parse(Console.ReadLine() ?? "0");

        var mineField = new List<List<int>>();
        var lineInStrings = new List<string>();

        for (int i = 0; i < y; i++)
        {
            string line = Console.ReadLine() ?? string.Empty;
            var charArrayLine = line.ToCharArray();
            foreach(var char in charArr)
            mineField.AddRange(line.ToList<string>());
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine("answer");
    }

    public static List<List<string>> CalculateMineField(List<List<string>> mineField, int x, int y)
    {

    }
}