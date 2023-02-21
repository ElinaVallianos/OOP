using System;
namespace HomeWork18
{
	public enum Status
	{
		Single,
		Alfa,
		Betta,
		Omega,
	}
	public class Wolf : Canine
	{
		private Status status;
		private int puppies;

        internal Status Status { get => status; set => status = value; }
        public int Puppies
		{
			get => puppies;
			set
			{
				if (Sex == Sex.Female || Sex == Sex.Unknown)
				{
					puppies = value;
					return;
				}
				Console.WriteLine("NOTIFICATION: Male wolfs don't have puppies.\n");
			}
		}

        public Wolf(string habitat, int age, int hight) : base(habitat, age, hight)
		{
		}

        public override void GetLifeInfo()
        {
            base.GetLifeInfo();
			Console.Write($"Status in a Pack: {Status}. ");
			if (Sex ==  Sex.Female || Sex == Sex.Unknown)
			{
				Console.Write($"Has {puppies} puppies.\n");
				return;
			}
			Console.Write("Does not have any puppies.\n");
        }
    }
}

