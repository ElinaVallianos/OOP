using System;
namespace Lesson21
{
	//можно не реализововать метод Print, так как у него уже есть реализация по умолчанию в интерфейсе
	public class Thing : IPrintable
	{
		//статические члены класса являются общими для всех экземпляров (или объектов класса)
		//статическое поле будет одно для всех экземпляров 
		private static int counter;
		public static int Counter { get => counter; }

		private string name;
        public string Name { get => name; set => name = value; }

		public Thing(string name)
		{
			counter++;
			this.name = name;
		}

		//автосвойство - компилятор автоматически создаст поле для него
		public int Weight { get; set; }

		//переопределение операторов сравнения 
		public static bool operator > (Thing thing1, Thing thing2)
		{
			return thing1.Weight > thing2.Weight;
		}

        public static bool operator < (Thing thing1, Thing thing2)
        {
            return thing1.Weight < thing2.Weight;
        }

        public static bool operator == (Thing thing1, Thing thing2)
        {
            return thing1.Weight == thing2.Weight;
        }

        public static bool operator != (Thing thing1, Thing thing2)
        {
            return thing1.Weight != thing2.Weight;
        }
    }
}

