using System;
namespace Lesson18
{
	public class Car : Transport
	{

		public Car(int seats) : base(seats)
		{
		}

		//виртуальный метод можно(!) переопределить в классе наследнике
		public virtual void Move()
		{
			Console.WriteLine($"Move by {Speed} km/h");
		}

        public override void GetSeats()
        {
            Console.WriteLine($"Have a {seats} seats.");
        }
    }
}

