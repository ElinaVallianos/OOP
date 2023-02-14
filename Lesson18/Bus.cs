using System;
namespace Lesson18
{
    public class Bus : Car
    {
        private int route;
        private int passengers;

        public int Route { get => route; set => route = value; }
        public int Passengers { get => passengers; set => passengers = value; }

        public Bus(int seats) : base(seats)
        {
        }

        public override void Move()
        {
            //вызываем сначала метод Move() базового класса
            base.Move();

            Console.WriteLine($"On route {route}. {passengers} passengers, {seats - passengers} empty sears.");
        }

        public override void GetSeats()
        {
            Console.WriteLine($"Have a {seats} seats, {seats - passengers} empty sears.");
        }
    }
}

