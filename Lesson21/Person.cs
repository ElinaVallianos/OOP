using System;
namespace Lesson21
{
    //  СТРУКТУРЫ - это значимый тип
    //  структуры не поддерживают наследование, но могут реализовывать интерфейсы
    public struct Person : IPrintable
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        //структура всегда содержит конструктов без параметов (скрытый конструктор без параметров),
        // который инициализирует все поля значениями по умолчанию

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //заменяем реализацию по умолчанию интерфейса IPrintable
        public void Print()
        {
            Console.WriteLine($"Name - {Name}, Age - {Age}");
        }
    }
}

