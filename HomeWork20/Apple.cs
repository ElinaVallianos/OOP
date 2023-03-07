using System;
namespace HomeWork20
{
	public class Apple : GameObject, IInteractional
	{
        private int power;

        public Apple(int x, int y, int power) : base(x, y)
        {
            this.power = power;
        }

        public void Heal(IHealable target)
        {
            target.Healing(power);
        }

        public void Interact(GameObject obj)
        {
            if (Position.X == obj.Position.X && Position.Y == obj.Position.Y)
            {
                Console.WriteLine($"{this}\tInteracion with {obj}");

                if (obj is IHealable)
                {
                    Heal((IHealable)obj);
                    Position.Y = -1;
                }
            }
        }
    }
}

