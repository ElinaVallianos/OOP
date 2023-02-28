using System;
namespace Lesson20
{
    public class InheitedClassA : BaseClass
    {
        public InheitedClassA(string name) : base(name)
        {
        }

        public override void Print()
        {
            WhoAmI();
            Console.WriteLine($"InteritedA");
        }
    }

    public class InheitedClassB : BaseClass
    {
        public InheitedClassB(string name) : base(name)
        {
        }

        //скрываем метод базового класса с помощю слова new
        private new void WhoAmI()
        {
            Console.WriteLine("I am InteritedB.");
        }

        //скрываем виртуальный метод базового класса
        public new void Print()
        {
            //можно получить доступ к скрытому методу через "base."
            base.WhoAmI();
            WhoAmI();
        }
    }
}

