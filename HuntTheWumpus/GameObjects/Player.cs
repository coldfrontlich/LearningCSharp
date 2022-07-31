using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus.GameObjects
{

    public class Player : GameObject
    {
        public Player(Coordinates coordinates) : base(coordinates, "[@]")
        {
            IsAlive = true;
        }
        public bool IsAlive { get; set; }
    }
}
