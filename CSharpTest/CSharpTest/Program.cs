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
        Console.Error.WriteLine("n INPUT");
        int N = int.Parse(Console.ReadLine());
        Console.Error.WriteLine(N);

        Console.Error.WriteLine("Split");
        var listOfTemps = new List<int>();
        if (N != 0)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                int t = int.Parse(inputs[i]);
                listOfTemps.Add(Math.Abs(t));
            }

            if (listOfTemps.Count > 0)
            {
                var minTemp = listOfTemps.Min();
                Console.WriteLine(minTemp);
                return;
            }
        }


        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine("0");
    }
}