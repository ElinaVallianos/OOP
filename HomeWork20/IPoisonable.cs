using System;
namespace HomeWork20
{
	public interface IPoisonable
	{
        public int Health { get; }

        public void PoisonDamage(int power);
    }
}

