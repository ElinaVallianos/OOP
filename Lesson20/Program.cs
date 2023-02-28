namespace Lesson20;
class Program
{
    static void Main(string[] args)
    {
        BaseClass baseClass = new BaseClass("Name 1");
        InheitedClassA inheitedA = new InheitedClassA("Name 2");
        InheitedClassB inheitedB = new InheitedClassB("Name 3");

        baseClass.Print();
        inheitedA.Print();
        inheitedB.Print();

        //сохраняем наследников в переменной базового класса
        baseClass = inheitedA;
        //вызывается переопределенный метод
        baseClass.Print();

        baseClass = inheitedB;
        //вызвался метод базового класса
        baseClass.Print();

        ((InheitedClassB)baseClass).Print();

        //проверяем является ли значение в переменной  baseClass классом InheitedClassB
        if (baseClass is InheitedClassB)
        {
            //as - использовать как
            //приводим переменную базового типа к наследуемому
            (baseClass as InheitedClassB).Print();
        }
    }
}

