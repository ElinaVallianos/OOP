using System;
namespace HomeWork20
{
	public class GameObject
	{
        private Vector position;

        public Vector Position { get => position; set => position = value; }

        public GameObject(int x, int y)
        {
            this.position = new Vector(x, y);
        }
    }

    public class Vector
    {
        private int x;
        private int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"Position ({x}, {y})";
        }
    }
}

