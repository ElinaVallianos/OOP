using System;
namespace Lesson18
{
	public class CarOld
	{
        // модификатор protected дает доступ к члену класса в классе наследнике 
        protected int seats;
        private int speed;

        public int Speed { get => speed; set => speed = value; }

        public CarOld(int seats)
        {
            this.seats = seats;
        }

        //виртуальный метод можно(!) переопределить в классе наследнике
        public virtual void Move()
        {
            Console.WriteLine($"Move by {speed} km/h");
        }
    }
}

