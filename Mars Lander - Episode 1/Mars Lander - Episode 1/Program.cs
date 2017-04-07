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
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string temps = Console.ReadLine(); // the n temperatures expressed as integers ranging from -273 to 5526
        int closest = 0;
        int minDifference = int.MaxValue;
        if (n > 0)
        {
            List<int> tempArray = temps.Split(' ').Select(int.Parse).ToList();

            foreach (int temp in tempArray)
            {
                int diff = Math.Abs(temp - 0);
                if (minDifference > diff)
                {
                    minDifference = diff;
                    closest = temp;
                }
            }
            if (tempArray.Contains(Math.Abs(closest)))
            {
                closest = Math.Abs(closest);
            }
        }

        Console.WriteLine(closest);
    }
}