using System;
namespace HomeWork17
{
	public class Hydrogen
	{
		private Oxygen? oxygen1;

        public Oxygen? Oxygen1 { get => oxygen1; set => oxygen1 = value; }

		public Hydrogen()
		{
		}


        public void React(Oxygen oxygen) //здесь тоже проверять наналичие свободных полей?
		{
			if (this.oxygen1 != null) return;
			if (oxygen.Hidrogen1 == null)
			{
				oxygen.Hidrogen1 = this;
				this.oxygen1 = oxygen;
				return;
			}

			if (oxygen.Hidrogen2 == null)
			{
                oxygen.Hidrogen2 = this;
                this.oxygen1 = oxygen;
            }
		}
	}
}

