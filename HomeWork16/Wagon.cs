using System;
namespace HomeWork16
{
	public enum WagonType
	{
		Cupe,
		Lux,
		Restaurant
	}

	public class Wagon
	{

		private int number;
		private WagonType type;
		private Wagon? previousWagon;
		private Wagon? nextWagon;

        public int Number { get => number; set => number = value; }
        public WagonType Type { get => type; private set => type = value; }
        public Wagon? PreviousWagon { get => previousWagon; set => previousWagon = value; }
        public Wagon? NextWagon { get => nextWagon; set => nextWagon = value; }

		public Wagon(int number, WagonType type)
		{
			this.number = number;
			this.type = type;
		}
    }
}

