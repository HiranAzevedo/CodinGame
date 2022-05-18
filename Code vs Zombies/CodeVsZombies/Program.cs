using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Save humans, destroy zombies!
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;

        // game loop
        while (true)
        {


            inputs = (Console.ReadLine() ?? string.Empty).Split(' ');
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);

            var ash = (x, y);

            int humanCount = int.Parse(Console.ReadLine() ?? string.Empty);
            var humans = new Dictionary<int, (int coordX, int coordY)>(humanCount);

            for (int i = 0; i < humanCount; i++)
            {
                inputs = (Console.ReadLine() ?? string.Empty).Split(' ');
                int humanId = int.Parse(inputs[0]);
                int humanX = int.Parse(inputs[1]);
                int humanY = int.Parse(inputs[2]);

                (int coordx, int coordY) coord = (humanX, humanY);
                humans.Add(humanId, coord);
            }

            int zombieCount = int.Parse(Console.ReadLine() ?? string.Empty);
            var zombies = new Dictionary<int, (int coordX, int coordY)>(zombieCount);

            for (int i = 0; i < zombieCount; i++)
            {
                inputs = (Console.ReadLine() ?? string.Empty).Split(' ');
                int zombieId = int.Parse(inputs[0]);
                int zombieX = int.Parse(inputs[1]);
                int zombieY = int.Parse(inputs[2]);

                (int coordx, int coordY) coord = (zombieX, zombieY);
                zombies.Add(zombieId, coord);

                int zombieXNext = int.Parse(inputs[3]);
                int zombieYNext = int.Parse(inputs[4]);

            }

            (var coordX, var coordY) = SelectWhereToGo(humans, zombies, ash);

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");


            Console.WriteLine($"{coordX} {coordY}"); // Your destination coordinates

        }
    }

    private static (string coordX, string coordY) SelectWhereToGo(Dictionary<int, (int, int)> humans, Dictionary<int, (int, int)> zombies, (int x, int y) ash)
    {
        var listOfTargets = new List<Attack>();

        foreach (var zombie in zombies)
        {
            foreach (var humam in humans)
            {
                var distance = Math.Round(Math.Sqrt(Math.Pow(zombie.Value.Item1 - humam.Value.Item1, 2) + Math.Pow(zombie.Value.Item2 - humam.Value.Item2, 2)));
                Console.Error.WriteLine($"Distancia calculada: {distance}");
                listOfTargets.Add(new Attack { Distance = distance, HumamId = humam.Key, ZombieId = zombie.Key });
            }
        }

        var target = listOfTargets.Min(x => x.Distance);


        zombies.First(x => x.Key == target.)



    }

    private class Attack
    {
        public int HumamId { get; set; }
        public int ZombieId { get; set; }
        public double Distance { get; set; }
    }
}