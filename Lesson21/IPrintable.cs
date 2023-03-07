using System;
namespace Lesson21
{
	//Интерфейсы могут наследоваться от других интерфейсов
	public interface IPrintable : INamed 
	{
		//это реализация метода по умолчанию (начиная с C# 8.0)
		public void Print()
		{
			Console.WriteLine($"Name - {Name}");
		}
	}
}

