using System;
namespace HomeWork18
{
	public enum Sex
	{
		Unknown,
		Male,
		Female
	}
	public class Canine : Creature
	{
		private Sex sex;
		protected  int hight;

        internal Sex Sex { get => sex; set => sex = value; }

		public Canine(string habitat, int age, int hight) : base(habitat, age)
		{
			this.hight = hight;
		}

		public virtual void GetLifeInfo()
		{
            Console.WriteLine($"Hight: {hight} sm.");
        }


        public override void GetInfo()
        {
            Console.WriteLine($"Sex: {sex}, age: {age} years. Lives in {Habitat}. Diet: {Food}.");
        }
    }
}

