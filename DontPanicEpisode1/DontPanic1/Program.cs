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
    public const string RIGHT = "RIGHT";
    public const string LEFT = "LEFT";
    public const string BLOCK = "BLOCK";
    public const string WAIT = "WAIT";

    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int nbFloors = int.Parse(inputs[0]); // number of floors
        int width = int.Parse(inputs[1]); // width of the area
        int nbRounds = int.Parse(inputs[2]); // maximum number of rounds
        int exitFloor = int.Parse(inputs[3]); // floor on which the exit is found
        int exitPos = int.Parse(inputs[4]); // position of the exit on its floor
        int nbTotalClones = int.Parse(inputs[5]); // number of generated clones
        int nbAdditionalElevators = int.Parse(inputs[6]); // ignore (always zero)
        int nbElevators = int.Parse(inputs[7]); // number of elevators

        var elevatorList = new List<Elevator>(nbElevators);

        for (int i = 0; i < nbElevators; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            int elevatorFloor = int.Parse(inputs[0]); // floor on which this elevator is found
            int elevatorPos = int.Parse(inputs[1]); // position of the elevator on its floor
            var elevator = new Elevator(elevatorFloor, elevatorPos);
            elevatorList.Add(elevator);
        }

        // game loop
        while (true)
        {
            inputs = (Console.ReadLine() ?? string.Empty).Split(' ');

            int cloneFloor = int.Parse(inputs[0]); // floor of the leading clone
            int clonePos = int.Parse(inputs[1]); // position of the leading clone on its floor
            string direction = inputs[2]; // direction of the leading clone: LEFT or RIGHT

            if (cloneFloor == exitFloor)
            {
                if (exitPos < clonePos && direction == RIGHT)
                {
                    Console.WriteLine(BLOCK);
                    continue;
                }
                if (exitPos > clonePos && direction == LEFT)
                {
                    Console.WriteLine(BLOCK);
                    continue;
                }
                else
                {
                    Console.WriteLine(WAIT);
                    continue;
                }
            }
            var elevatorInFloor = elevatorList.FirstOrDefault(x => x.Floor == cloneFloor);
            if (elevatorInFloor != null)
            {
                if (elevatorInFloor.Position < clonePos && direction == RIGHT)
                {
                    Console.WriteLine(BLOCK);
                    continue;
                }
                if (elevatorInFloor.Position > clonePos && direction == LEFT)
                {
                    Console.WriteLine(BLOCK);
                    continue;
                }
                else
                {
                    Console.WriteLine(WAIT);
                    continue;
                }
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine("BLOCK"); // action: WAIT or BLOCK

        }
    }

    public class Elevator
    {
        public Elevator(int floor, int position)
        {
            Floor = floor;
            Position = position;
        }

        public int Floor { get; }
        public int Position { get; }
    }
}