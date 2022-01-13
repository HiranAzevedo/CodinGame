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
public class Solution
{
    public static List<char> BASEALPH => new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

    static void Main(string[] args)
    {
        string operation = Console.ReadLine() ?? string.Empty;

        int pseudoRandomNumber = int.Parse(Console.ReadLine() ?? "0");

        var rotorList = new List<List<char>>();

        for (int i = 0; i < 3; i++)
        {
            string rotor = Console.ReadLine() ?? string.Empty;
            rotorList.Add(new List<char>(rotor.ToCharArray()));
        }

        string message = Console.ReadLine() ?? string.Empty;
        var result = string.Empty;

        if (operation == "ENCODE")
        {
            result = Encode(pseudoRandomNumber, rotorList, message);
        }
        if (operation == "DECODE")
        {
            result = Decode(pseudoRandomNumber, rotorList, message);
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(result);
    }

    public static string Encode(int numberKey, List<List<char>> rotorList, string message)
    {
        var msgShifted = string.Empty;
        var increment = 0;

        foreach (var charMsg in message)
        {
            var currentIndex = BASEALPH.IndexOf(charMsg);
            var shiftNumber = numberKey + increment + currentIndex;

            if (shiftNumber >= BASEALPH.Count)
            {
                shiftNumber %= BASEALPH.Count;
            }

            var charIncremented = BASEALPH[shiftNumber];
            msgShifted = $"{msgShifted}{charIncremented}";
            increment++;
        }

        var msgRotored = msgShifted;

        foreach (var rotor in rotorList)
        {
            var auxStringRotored = string.Empty;
            foreach (var key in msgRotored)
            {
                var indexAlph = BASEALPH.IndexOf(key);
                var rotoredChar = rotor[indexAlph];
                auxStringRotored = $"{auxStringRotored}{rotoredChar}";
            }
            msgRotored = auxStringRotored;
        }

        return msgRotored;
    }

    public static string Decode(int numberKey, List<List<char>> rotorList, string message)
    {
        rotorList.Reverse();

        var msgRotored = message;

        foreach (var rotor in rotorList)
        {
            var auxStringRotored = string.Empty;
            foreach (var key in msgRotored)
            {
                var indexAlph = rotor.IndexOf(key);
                var rotoredChar = BASEALPH[indexAlph];
                auxStringRotored = $"{auxStringRotored}{rotoredChar}";
            }
            msgRotored = auxStringRotored;
        }

        var increment = 0;
        var msgShifted = string.Empty;

        foreach (var charMsg in msgRotored)
        {
            var currentIndex = BASEALPH.IndexOf(charMsg);
            var shiftNumber = currentIndex - numberKey - increment;

            if (shiftNumber >= BASEALPH.Count)
            {
                shiftNumber %= BASEALPH.Count;
            }

            if (shiftNumber < 0)
            {
                shiftNumber %= BASEALPH.Count * -1;
                if(shiftNumber < 0)
                {
                    shiftNumber = BASEALPH.Count + shiftNumber;
                }                
            }

            var charIncremented = BASEALPH[shiftNumber];

            msgShifted = $"{msgShifted}{charIncremented}";
            increment++;
        }

        return msgShifted;
    }
}