using System;
namespace Lesson19
{
	public interface IDamageble
	{
		public int Health { get; }

		public void Damage(int power);
	}
}

