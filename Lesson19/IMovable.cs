using System;
namespace Lesson19
{
	//интерфейс определяет способ взаимодействия с объектом
	//может иметь публичные свойства или методы без реализации
	public interface IMovable
	{
		public Vector2 Direction { get; set; }
		public void Move();
	}
}

