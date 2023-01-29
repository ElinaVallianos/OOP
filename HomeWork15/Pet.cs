using System;
namespace HomeWork15
{
	public enum PetType
	{
		Cat,
		Dog
	}

	public class Pet
	{
		private PetType type;
		private string name;
		private int weight;

        public string Name { get => name; }
        public int Weight { get => weight; set => weight = value; }
        internal PetType Type { get => type; set => type = value; }

        public Pet(string name, PetType type, int weight)
		{
			this.Type = type;
			this.name = name;
			this.weight = weight;
		}

		public Pet(string name, PetType type )
		{
			this.Type = type;
			this.name = name;
		}
	}
}

