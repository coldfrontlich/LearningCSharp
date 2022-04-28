using HuntTheWumpus.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    public class Game
    {
        public void Start()
        {
            Map map = new Map(6);

            Player player = new Player();
            Wumpus wumpus = new Wumpus();

            //map.AddObject(player);
            //map.AddObject(wumpus);

            while (player.IsAlive && wumpus.IsAlive)
            {
                Console.Clear();
                PrintMap(map.GetMap());
                ConsoleKeyInfo userInput = Console.ReadKey(true);

                if (userInput.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }

            if (player.IsAlive)
                Console.WriteLine("Вы победили");

            if (wumpus.IsAlive)
                Console.WriteLine("Вас съел Вумпус");
        }

        public void PrintMap(string[,] map)
        {
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    Console.Write(map[x, y]);
                }

                Console.WriteLine();
            }
        }
    }
}
