using System;
namespace Lesson17
{ 
	public enum WagonType
	{
		Cupe,
		Reastaurant,
		Lux
	}

    public class Wagon
	{
		private WagonType type;
		private Wagon? next;
		private Wagon? prev;

		public WagonType Type { get => type; }
		public Wagon? Prev { get => prev; set => prev = value; }
		public Wagon? Next { get => next; set => next = value; }

		public Wagon( WagonType type)
		{
			this.type = type;
		}
	}
}

