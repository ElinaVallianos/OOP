using System;
using System.Xml.Linq;

namespace HomeWork21
{
	public struct MyStruct : IPrint, IComparable, INamed, INumerable
	{
		private string description;
        public string Description { get => description; set => description = value; }

        public string Name { get ; set; }
        public int Number { get ; set ; }

        public void Print()
        {
            Console.WriteLine($"{Number}. {Name}. {Description}");
        }
    }
}

