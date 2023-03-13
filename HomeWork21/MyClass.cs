using System;
namespace HomeWork21
{
	public class MyClass: INumerable, INamed, IComparable, IPrint
	{
        public int Number { get; set; }
        public string Name { get ; set ; }

		public MyClass()
		{
		}

        public MyClass(int number)
        {
            this.Number = number;
        }

        public void Print()
        {
            Console.WriteLine($"{Number}. {Name}");
        }
    }
}

