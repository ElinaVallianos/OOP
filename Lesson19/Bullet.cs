using System;
namespace Lesson19
{
	public class Bullet : GameObject, IMovable
	{
        private Vector2 direction;
        private int power;
        
        public Vector2 Direction { get => direction; set => direction = value; }

        public Bullet(int x, int y, int power, Vector2 diraction) : base(x, y)
        {
            this.direction = diraction;
            this.power = power;
        }


        void IMovable.Move()
        {
            Position.X += direction.X;
            Position.Y += direction.Y;

            Console.WriteLine($"{this} {Position}");
        }

        public void Attack(IDamageble target)
        {
            target.Damage(power);
        }
    }
}

