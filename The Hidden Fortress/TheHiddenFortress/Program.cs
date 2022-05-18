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
    public static readonly string[] LettersValue = new string[] { "", "" };
    static void Main(string[] args)
    {
        int SIZE = int.Parse(Console.ReadLine() ?? string.Empty);
        var grid = new List<List<string>>(SIZE);

        for (int i = 0; i < SIZE; i++)
        {
            string ROW = Console.ReadLine() ?? string.Empty;
            var rowSplited = ROW.Split("");
            grid.Add(new List<string>(rowSplited));
        }
        for (int i = 0; i < SIZE; i++)
        {

            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine("revealed row");
        }
    }
}