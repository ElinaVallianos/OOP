using System;
namespace HomeWork18
{
	public class Fox : Canine
	{
		private int daysWithoutFood;

        public int DaysWithoutFood { get => daysWithoutFood; set => daysWithoutFood = value; }

		public Fox(string habitat, int age, int hight, int days) : base(habitat,age, hight)
		{
			this.daysWithoutFood = days;
		}

        public override void GetLifeInfo()
		{
			Console.WriteLine($"The fox had {daysWithoutFood} days of unsuccessful hunting.");
		}
    }
}

