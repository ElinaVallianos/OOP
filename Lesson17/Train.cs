using System;
namespace Lesson17
{
	public class Train
	{
		private Wagon? firstWagon;
		public Train()
		{
		}

		public Wagon? GetWagon(int number)
		{
			var currentWagon = firstWagon;

			for( int i = 1; i < number; i++)
			{
				if (currentWagon == null) break;
				currentWagon = currentWagon.Next;
			}
			return currentWagon;
		}

		public void AddWagon(Wagon wagon)
		{
			if (firstWagon == null)
			{
				firstWagon = wagon;
				return;
			}
			var currentWagon = firstWagon;

			while ( currentWagon.Next != null)
			{
				currentWagon = currentWagon.Next;
			}
			currentWagon.Next = wagon;
			//currentWagon.Next.Prev = currentWagon;
			wagon.Prev = currentWagon;
		}

		public void AddWagon(Wagon wagon, int number)
		{
			var currentWagon = GetWagon(number);
			if ( currentWagon == null)
			{
				AddWagon(wagon);
				return;
			}

			var prevWagon = currentWagon.Prev;

			if (prevWagon != null) prevWagon.Next = wagon;
			wagon.Prev = prevWagon;
			wagon.Next = currentWagon;
			currentWagon.Prev = wagon;
		}

		public void RemoveWagon(int number)
		{
			var wagon = GetWagon(number);
			if (wagon == null) return;

			var nextW = wagon.Next;
			var prevW = wagon.Prev;

			if (nextW != null) nextW.Prev = prevW;
			if (prevW != null) prevW.Next = nextW;
		}

		public void Print()
		{
			var currentWagon = firstWagon;
			var number = 1;

			while (currentWagon != null)
			{
				Console.WriteLine($"Wagon {number} - {currentWagon.Type}");
				currentWagon = currentWagon.Next;
				number++;
			}
		}
	}
}

