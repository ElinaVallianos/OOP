using System;
namespace HomeWork20
{
	public interface IHealable
	{
        public int Health { get; }

        public void Healing(int power);
    }
}

