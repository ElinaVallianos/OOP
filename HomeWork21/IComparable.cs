using System;
namespace HomeWork21
{
	public interface IComparable : INumerable
	{
        public static bool operator > (IComparable  item1,  IComparable item2)
        {
            return item1.Number > item2.Number;
        }

        public static bool operator < (IComparable item1, IComparable item2)
        {
            return item1.Number < item2.Number;
        }

        //public void Compare()
        //{
        //}

  //      public bool Compare(IComparable item)
		//{
  //          return this > item;
		//}
	}
}

