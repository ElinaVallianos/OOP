using System;
namespace Lesson19
{
	public class Bullet : GameObject, IMovable, ICollideble 
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

        public void Collide(GameObject obj)
        {
            if (Position.X == obj.Position.X && Position.Y == obj.Position.Y)
            {
                Console.WriteLine($"{this}\tCollision with {obj}");

                //оператор is проверяет представляет ли значение определенный тип или интерфейс
                if (obj is IDamageble)
                {
                    //приводим объект типа GameObject к интерфейсу IDamageble
                    Attack((IDamageble)obj);
                    Rebound();
                }
                else
                {
                    Rebound();
                }
            }
        }

        //отскок - изменение направления на противоположное
        private void Rebound()
        {
            direction.X = -direction.X;
            direction.Y = -direction.Y;
        }
    }
}

