using System;
namespace Lesson18
{
    public class Track : Car
    {
        private int cargo;

        public int Cargo { get => cargo; set => cargo = value; }

        //base - ссылка на базовый класс
        //base(seats) - вызываем конструктор базового класса

        public Track(int seats, int cargo) : base(seats)
        {
            this.cargo = cargo;
        }

        //переопределянм метод базового класса
        public override void Move()
        {
            Console.WriteLine($"Track transports {cargo} kg of cargo.");
        }
    }
}

