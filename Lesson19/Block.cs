using System;
namespace Lesson19
{
	public class Block : Wall, IDamageble
	{
        private int health;

        public int Health => health;

        public Block(int x, int y, int health) : base(x, y)
        {
            this.health = health;
        }


        public void Damage(int power)
        {
            health -= power;
            Console.WriteLine($"{this}\t Health = {health}");

            if (health <= 0) Position.Y = -1;
        }
    }
}

