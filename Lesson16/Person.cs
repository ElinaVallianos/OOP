using System;
namespace Lesson16
{
	public class Person
	{
		private string name;

		//знак вопроса значит, что значение может быть null
		private Person? parent1;
		private Person? parent2;


		public Person(string name)
		{
			this.name = name;
		}

        public string Name { get => name; set => name = value; }
        public Person? Parent1 {
			get => parent1;
			set
			{
				if (value == this )
				{
					Console.WriteLine($"{this.Name} cann't be their parent.");
					return;
				}
				if (value != null && value == parent2)
				{
                    Console.WriteLine($"{value.Name} is already parent.");
                    return;
                }
				parent1 = value;
			}
		}
        public Person? Parent2 { get => parent2; set => parent2 = value; }
    }
}

