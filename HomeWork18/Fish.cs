using System;
namespace HomeWork18
{
	public class Fish : Creature
	{
		private int depth;
		private int length;

        public int Depth { get => depth; set => depth = value; }
        public int Length { get => length; set => length = value; }

		public Fish(string habitat, int age) : base(habitat,age)
		{
		}

		public void GetLength()
		{
			Console.WriteLine($"The fish's length at the age of {age} years is usually {length} sm.");
		}

        public override void GetInfo()
        {
			Console.WriteLine($"Age:{age} years. Lives in {Habitat} {depth} m. deep. Diet: {Food}.");
        }
    }
}

