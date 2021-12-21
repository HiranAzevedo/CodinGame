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
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine()?.Split(' ') ?? Array.Empty<string>();
        int x = int.Parse(inputs[0]);
        int y = int.Parse(inputs[1]);
        int qtdInputsX = int.Parse(inputs[2]);
        int qtdInputsY = int.Parse(inputs[3]);

        inputs = Console.ReadLine()?.Split(' ') ?? Array.Empty<string>();
        List<int> inputsX = new List<int>();
        for (int i = 0; i < qtdInputsX; i++)
        {
            inputsX.Add(int.Parse(inputs[i]));
        }

        inputs = Console.ReadLine()?.Split(' ') ?? Array.Empty<string>();
        List<int> inputsY = new List<int>();
        for (int i = 0; i < qtdInputsY; i++)
        {
            inputsY.Add(int.Parse(inputs[i]));
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        var result = CalculateSquares(inputsX, inputsY, x, y);

        Console.WriteLine(result);
    }


    public static int CalculateSquares(List<int> inputsX, List<int> inputsY, int x, int y)
    {
        var totalRectangle = 0;

        var spacesX = CalculateSpaces(inputsX, x);
        AddToDicResult(spacesX, x);

        var spacesY = CalculateSpaces(inputsY, y);
        AddToDicResult(spacesY, y);

        foreach (var spaceX in spacesX)
        {
            var spaceValue = spaceX.Key;
            if (spacesY.ContainsKey(spaceValue))
            {
                totalRectangle += spacesX[spaceValue] * spacesY[spaceValue];
            }
        }

        return totalRectangle;
    }

    private static Dictionary<int, int> CalculateSpaces(List<int> inputs, int maxValue)
    {
        Dictionary<int, int> spaces = new Dictionary<int, int>();

        for (int staticIndex = 0; staticIndex < inputs.Count; staticIndex++)
        {
            var element = inputs[staticIndex];
            var spaceFirst = element - 0;

            AddToDicResult(spaces, spaceFirst);

            var spaceSecond = maxValue - element;
            AddToDicResult(spaces, spaceSecond);

            if (staticIndex - 1 >= 0)
            {
                for (var decIndex = staticIndex - 1; decIndex >= 0; decIndex--)
                {
                    var spaceValue = element - inputs[decIndex];
                    AddToDicResult(spaces, spaceValue);
                }
            }
        }

        return spaces;
    }

    private static void AddToDicResult(Dictionary<int, int> spaces, int spaceValueBegin)
    {
        if (spaceValueBegin > 0)
        {
            if (spaces.ContainsKey(spaceValueBegin))
            {
                spaces[spaceValueBegin]++;
            }
            else
            {
                spaces[spaceValueBegin] = 1;
            }
        }
    }
}