using System;
namespace HomeWork17
{
	public class Oxygen
	{
		private Hydrogen? hidrogen1;
		private Hydrogen? hidrogen2;

        public Hydrogen? Hidrogen1 { get => hidrogen1;
			set
			{
				if (this.hidrogen1 == null && value?.Oxygen1 == null)
				{
					hidrogen1 = value;
				}
			}
		}
        public Hydrogen? Hidrogen2 { get => hidrogen2;
			set
			{
                if (this.hidrogen2 == null && value?.Oxygen1 == null)
                {
                    hidrogen2 = value;
                }
            }
		}

		public Oxygen()
		{
		}

		public void React( Hydrogen hydrogen)
		{
			if (this.hidrogen1 == null)
			{
				hidrogen1 = hydrogen;
				return;
			}
			hidrogen2 = hydrogen;
		}

    }
}

