using System;
namespace Lesson16
{
	public class Rectangle: Shape 
	{
        private int side1;
        private int side2;

        //переопределяем метод базового класса
        public override int Square { get => side1 * side2;}

        public Rectangle( int side1, int side2, int x, int y) : base(x,y)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
    }
}

