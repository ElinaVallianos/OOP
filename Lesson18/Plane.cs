using System;
namespace Lesson18
{
    public class Plane : Transport
    {
        private int altitude;

        public int Altitude { get => altitude; set => altitude = value; }

        public Plane(int seats) : base(seats)
        {
        }

        public void Fly()
        {
            //получаем доступ к свойству Speed базового класса
            Console.WriteLine($"Fly by {Speed} km/h, at altitude {altitude} meters");
        }

        public override void GetSeats()
        {
            Console.WriteLine($"Have a {seats} seats.");
        }
    }
}

