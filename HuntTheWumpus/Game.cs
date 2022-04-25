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
        private const byte MAX_MAP_SIZE = 6;
        public void Start()
        {
            Player player = new Player();
            Wumpus wumpus = new Wumpus();

            while (player.IsAlive && wumpus.IsAlive)
            {
                Console.Clear();
                PrintMap();
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

        public void PrintMap()
        {
            for (int y = 0; y < MAX_MAP_SIZE; y++)
            {
                for (int x = 0; x < MAX_MAP_SIZE; x++)
                {
                    Console.Write("[ ]");
                }

                Console.WriteLine();
            }
        }
    }
}
