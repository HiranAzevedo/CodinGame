using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
public static class Solution
{
    public static void Main(string[] args)
    {
        var inputs = (Console.ReadLine() ?? string.Empty).Split(' ');
        var seats = int.Parse(inputs[0]);
        var rounds = int.Parse(inputs[1]);
        var groupsQuantity = int.Parse(inputs[2]);

        var queue = new Queue<int>(groupsQuantity);

        for (var i = 0; i < groupsQuantity; i++)
        {
            var groupValue = int.Parse(Console.ReadLine() ?? "0");
            queue.Enqueue(groupValue);
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        var totalCash = RunRollerCoaster(queue, seats, rounds);

        Console.WriteLine(totalCash);
    }


    public static long RunRollerCoaster(Queue<int> queue, int seats, int rounds)
    {
        var queueArray = queue.ToArray();
        var arraySize = queueArray.Length;
        var cache = new Dictionary<int, (long value, int lastIndex)>();
        long totalCash = 0;
        var index = 0;
        var seatsOccupied = 0;

        for (; rounds > 0; rounds--)
        {
            if (cache.ContainsKey(index))
            {
                var cacheHit = cache[index];
                totalCash += cacheHit.value;
                index = cacheHit.lastIndex;
                seatsOccupied = 0;
            }
            else
            {
                var startIndex = index;
                for (var i = 0; i < arraySize && queueArray[index] + seatsOccupied <= seats; i++)
                {
                    seatsOccupied += queueArray[index];
                    index = index == arraySize - 1 ? 0 : index + 1;
                }

                cache.Add(startIndex, (seatsOccupied, index));
            }

            totalCash += seatsOccupied;
            seatsOccupied = 0;
        }

        return totalCash;
    }
}