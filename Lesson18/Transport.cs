using System;
namespace Lesson18
{
	public abstract class Transport
	{
        protected int seats;
        private int speed;

        public int Speed { get => speed; set => speed = value; }

        public Transport(int seats)
		{
            this.seats = seats;
		}

        public abstract void GetSeats();
    }
}

