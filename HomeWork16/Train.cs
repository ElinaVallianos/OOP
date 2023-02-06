using System;
namespace HomeWork16
{
	public class Train
	{
		private Wagon? wagon1;

        public Wagon? Wagon1 { get => wagon1; //не совсем поняла, где нужны проверки на null?
			set
			{
				if (value == null)
				{
                    Console.WriteLine($"There is not a wagon.");
                    return;
                }
				wagon1 = value;
			}
		}

		public Train()
		{
		}

        public Wagon? GetWagon( int number)
		{
			Wagon? currentWagon = wagon1;    // можно ли создать переменную  Текущий Вагон вне метода,
											 // чтобы использовать в других методах?
            while (currentWagon != null)
			{
				if (currentWagon.Number == number)
				{
					return currentWagon;
				}
				currentWagon = currentWagon.NextWagon;
			}
			return null;
		}

		public void AddWagon( WagonType type )
		{
			int number = 2;
			Wagon? curentWagon = wagon1;  
			while (curentWagon.NextWagon != null)
			{
				curentWagon = curentWagon.NextWagon;
				number++;
			}
			curentWagon.NextWagon = new Wagon(number, type);  //какого типа добавлять вагон?
		}

		public void AddWagon( int number, WagonType type)
		{
			if (GetWagon(number - 1) != null)
			{
                //(еще одно условие if) && GetWagon(number - 1).NextWagon != null


                //Wagon removedWagon = GetWagon(number - 1).NextWagon;
                //GetWagon(number - 1).NextWagon = new Wagon(number, WagonType.Cupe);

                //??? если я далее изменю GetWagon(number - 1).NextWagon,
                //то так как это ссылка, изменится и значение removedWagon?


                Wagon newWagon = new Wagon(number, type);
				newWagon.NextWagon = GetWagon(number);
				GetWagon(number - 1).NextWagon = newWagon;

				Wagon? currentWagon = newWagon.NextWagon;

				while (currentWagon != null)
				{
					currentWagon.Number++;
					currentWagon = currentWagon.NextWagon;
				}
			}
			{
				AddWagon(type);
			}
		}

		public void DeleteWagon( int number)
		{
			if (GetWagon(number) != null)
			{
				GetWagon(number - 1).NextWagon = GetWagon(number).NextWagon;
				Wagon? currentWagon = GetWagon(number).NextWagon;
				while (currentWagon != null)
				{
					currentWagon.Number--;
					currentWagon = currentWagon.NextWagon;
				}
			}
			{
				GetWagon(number - 1).NextWagon = null;
			}
		}

		public void Print()
		{
			Wagon? currentWagon = Wagon1;
			while (currentWagon != null)
			{
				Console.WriteLine($"Wagon #{currentWagon.Number}  -  Type {currentWagon.Type}");
				currentWagon = currentWagon.NextWagon;
			}
		}
    }
}

