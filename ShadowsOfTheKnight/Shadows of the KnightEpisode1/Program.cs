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
public class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = (Console.ReadLine() ?? string.Empty).Split(' ');
        int W = int.Parse(inputs[0]); // width of the building.
        int H = int.Parse(inputs[1]); // height of the building.
        int N = int.Parse(Console.ReadLine() ?? "0"); // maximum number of turns before game over.
        inputs = (Console.ReadLine() ?? string.Empty).Split(' ');
        int X0 = int.Parse(inputs[0]);
        int Y0 = int.Parse(inputs[1]);

        // game loop
        while (true)
        {
            string bombDir = Console.ReadLine() ?? string.Empty; // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");


            // the location of the next window Batman should jump to.
            Console.WriteLine("0 0");
        }
    }
}