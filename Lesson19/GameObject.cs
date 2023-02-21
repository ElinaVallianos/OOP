using System;
namespace Lesson19
{
	public class GameObject
	{
		private Vector2 position;

        public Vector2 Position { get => position; set => position = value; }

		public GameObject(int x, int y)
		{
            this.position = new Vector2(x, y);
		}

    }

	public class Vector2
	{
		private int x;
		private int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Vector2(int x, int y)
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

