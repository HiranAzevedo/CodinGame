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
class Player
{
    public const char WALL = '#';
    public const char SPACE = '.';
    public const char START = 'T';
    public const char CONTROLROOM = 'C';

    public const string RIGHT = "RIGHT";
    public const string LEFT = "LEFT";
    public const string UP = "UP";
    public const string DOWN = "DOWN";


    static void Main(string[] args)
    {
        string[] inputs;
        inputs = (Console.ReadLine() ?? string.Empty).Split(' ');
        int mazeRows = int.Parse(inputs[0]); // number of rows.
        int mazeColumns = int.Parse(inputs[1]); // number of columns.
        int countDown = int.Parse(inputs[2]); // number of rounds between the time the alarm countdown is activated and the time the alarm goes off.
        List<string> Maze = new List<string>();
        Stack<string> MazeSteps = new Stack<string>();
        int startColumn = 0;
        int startRow = 0;
        bool firstRow = true;
        bool foundControlRoom = false;
        int controlRoomColumn = 0;
        int controlRoomRow = 0;

        // game loop
        while (true)
        {
            inputs = (Console.ReadLine() ?? string.Empty).Split(' ');
            int KR = int.Parse(inputs[0]); // row where Rick is located.
            int KC = int.Parse(inputs[1]); // column where Rick is located.

            if (firstRow)
            {
                startRow = KR;
                startColumn = KC;
                firstRow = false;
            }

            for (int i = 0; i < mazeRows; i++)
            {
                string ROW = (Console.ReadLine() ?? string.Empty); // C of the characters in '#.TC?' (i.e. one line of the ASCII maze).
                Maze.Add(ROW);

                if (ROW.Contains(CONTROLROOM))
                {
                    controlRoomColumn = ROW.IndexOf(CONTROLROOM);
                    foundControlRoom = true;
                    controlRoomRow = i;
                }
            }

            if (foundControlRoom)




                // Write an action using Console.WriteLine()
                // To debug: Console.Error.WriteLine("Debug messages...");

                Console.WriteLine("RIGHT"); // Rick's next move (UP DOWN LEFT or RIGHT).

        }
    }
}