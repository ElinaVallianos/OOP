using System;
namespace HomeWork20
{
	public class Poison : GameObject, IInteractional
	{
		private int power;

        public Poison(int x, int y, int power) : base(x, y)
        {
            this.power = power;
        }

        public void Attack(IPoisonable target)
        {
            target.PoisonDamage(power);
        }

        public void Interact(GameObject obj)
        {
            if (Position.X == obj.Position.X && Position.Y == obj.Position.Y)
            {
                Console.WriteLine($"{this}\tInteracion with {obj}");

                if (obj is IPoisonable)
                {
                    Attack((IPoisonable)obj);
                    Position.Y = -1;
                }
            }
        }
    }
}

