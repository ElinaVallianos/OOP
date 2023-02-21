using System;
namespace Lesson19
{
	public class Block : GameObject, IDamageble
	{
        private int health;

        public int Health => health;

        public Block(int x, int y) : base(x, y)
        {
        }


        public void Damage(int power)
        {
            health -= power;
            Console.WriteLine($"{this}\t Health = {health}");

            if (health <= 0) Position.Y = -1;
        }
    }
}

