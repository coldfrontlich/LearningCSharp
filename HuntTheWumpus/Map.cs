using HuntTheWumpus.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    public class Map
    {
        private GameObject[] _gameObjects;
        private string[,] _map;

        public Map(byte mapSize)
        {
            _map = new string[mapSize, mapSize];

            for (int y = 0; y < mapSize; y++)
            {
                for (int x = 0; x < mapSize; x++)
                {
                    _map[x, y] = "[ ]";
                }
            }
        }

        public void AddObject(GameObject gameObject)
        {
            throw new NotImplementedException();
        }

        public string[,] GetMap()
        {
            return _map;
        }
    }
}
