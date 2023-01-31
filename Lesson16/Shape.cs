using System;
namespace Lesson16
{
	//абстрактный класс - класс, у которого один или более метадов так же абстрактны
	// нельзя создать экземпляр абстрактного класса
	public abstract class Shape
	{
		private Point center;

        public abstract int Square { get; }

		public Shape(int x, int y)
		{
			center = new Point();
			center.X = x;
			center.Y = y;
		}

        public class Point
		{
			private int x;
			private int y;

            public int X { get => x; set => x = value; }
            public int Y { get => y; set => y = value; }
        }
	}
}

