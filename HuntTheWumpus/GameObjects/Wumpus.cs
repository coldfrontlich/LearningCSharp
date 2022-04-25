namespace HuntTheWumpus.GameObjects
{
    public class Wumpus : GameObject
    {
        public Wumpus()
        {
            IsAlive = true;
        }

        public bool IsAlive { get; set; }
    }
}
