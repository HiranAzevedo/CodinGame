using System;
using System.Collections.Generic;
using System.Linq;
/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        List<int> horsesPower = new List<int>();
        for (int i = 0; i < N; i++)
        {
            int pi = int.Parse(Console.ReadLine());
            horsesPower.Add(pi);
        }

        List<int> orderedHorses = horsesPower.OrderByDescending(i => i).ToList();

        int smallestPowerDiference = int.MaxValue;

        for (int i = 0; i < orderedHorses.Count; i++)
        {
            if (i == 0)
            {
                smallestPowerDiference = orderedHorses[i] - orderedHorses[i + 1];
            }
            else if (orderedHorses[i - 1] - orderedHorses[i] < smallestPowerDiference)
            {
                smallestPowerDiference = orderedHorses[i - 1] - orderedHorses[i];
            }
        }

        Console.WriteLine(smallestPowerDiference);
        Console.ReadLine();
    }
}