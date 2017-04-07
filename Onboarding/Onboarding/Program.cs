using System;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {
        // game loop
        while (true)
        {
            int index = 0;
            int maxMountain  =0;
            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain, from 9 to 0.
                if(maxMountain < mountainH)
                {
                    index = i;
                    maxMountain = mountainH;
                }
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(index); // The number of the mountain to fire on.
        }
    }
}