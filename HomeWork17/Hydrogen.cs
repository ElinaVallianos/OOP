using System;
namespace HomeWork17
{
	public class Hydrogen
	{
		private Oxygen? oxygen1;

        public Oxygen? Oxygen1 { get => oxygen1;
			set
			{
				if (this.Oxygen1 == null && (value?.Hidrogen1 == null || value?.Hidrogen2== null))
				{
					oxygen1 = value;
				}
			}
		}

		public Hydrogen()
		{
		}


        public void React(Oxygen oxygen) //здесь тоже проверять наналичие свободных полей?
		{
			this.oxygen1 = oxygen;
		}
	}
}

