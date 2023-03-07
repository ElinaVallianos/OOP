using System;
namespace HomeWork20
{
	public class Bird : GameObject, IMovable, IPoisonable, IHealable, IInteractional
	{
        private Vector direction;
        private int health;

        public Vector Direction { get => direction; set => direction = value; }

        public int Health { get => health; }

        public Bird(int x, int y, int health) : base(x, y)
        {
            direction = new Vector(0, 0);
            this.health = health;
        }

        public void Move()
        {
            Position.X += direction.X;
            Position.Y += direction.Y;

            Console.WriteLine($"{this} {Position}");
        }

        public void PoisonDamage(int power)
        {
            health -= power;

            Console.WriteLine($"{this}\t Health = {health}");
        }

        public void Healing(int power)
        {
            health += power;

            Console.WriteLine($"{this}\t Health = {health}");
        }

        public void Interact(GameObject obstacle)
        {
            if (obstacle is Wall && Position.X == obstacle.Position.X && Position.Y == obstacle.Position.Y)
            {
                Console.WriteLine($"{this}\tInteract with {obstacle}");

                switch (direction.X)
                {
                    case < 0 :
                        direction.X = 0;
                        direction.Y = 1;
                        break;
                    case > 0:
                        direction.X = 0;
                        direction.Y = -1;
                        break;
                    case 0:
                        if (direction.Y > 0)
                        {
                            direction.X = 1;
                            direction.Y = 0;
                            break;
                        }
                        direction.X = -1;
                        direction.Y = 0;
                        break;
                    default:
                        break;
                }
                
            }
        }
    }
}

