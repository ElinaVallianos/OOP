using System;
namespace HomeWork18
{
	public abstract class Creature
	{
		private string habitat;
		private string food;
		protected int age;

        public string Habitat { get => habitat; set => habitat = value; }
        public string Food { get => food; set => food = value; }

		public Creature(string habitat, int age)
		{
			this.age = age;
			this.habitat = habitat;
		}

		public abstract void GetInfo();
    }
}

