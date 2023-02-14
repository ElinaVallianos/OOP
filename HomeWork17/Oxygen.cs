using System;
namespace HomeWork17
{
	public class Oxygen
	{
		private Hydrogen? hidrogen1;
		private Hydrogen? hidrogen2;

        public Hydrogen? Hidrogen1 { get => hidrogen1; set => hidrogen1 = value; }
        public Hydrogen? Hidrogen2 { get => hidrogen2; set => hidrogen2 = value; }

        public Oxygen()
		{
		}

		public void React( Hydrogen hydrogen)
		{
			if (hydrogen.Oxygen1 != null) return;
			if (hidrogen1 == null)
			{
				hidrogen1 = hydrogen;
				hidrogen1.Oxygen1 = this;
				return;
			}

			if (hidrogen2 == null)
			{
                hidrogen2 = hydrogen;
                hidrogen2.Oxygen1 = this;
            }
		}

    }
}

