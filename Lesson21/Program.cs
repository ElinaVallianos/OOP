namespace Lesson21;
class Program
{
    static void Main(string[] args)
    {
        Thing thing1 = new Thing("pen");
        //мы можем сохранить объект типа Thing в переменнуу типа Iprintable
        IPrintable printable = new Thing("pencil");
        // и INabed, благодаря наследованию интерфейсов
        INamed named = new Thing("table");

        //статические члены вызываются от имени класса, а не объекта
        Console.WriteLine("Total number: " + Thing.Counter);

        thing1.Weight = 10;
        Thing thing2 = (Thing)printable;
        Thing thing3 = (Thing)named;
        thing2.Weight = 10;
        thing3.Weight = 1000;

        //используется переопределенный оператор и сравнивается вес
        if (thing1 == thing2)
        {
            Console.WriteLine("The weight is equals");
        }
        //сравнивается ссылки (что переменные ссылаются на один объект) 
        Console.WriteLine(thing1.Equals(thing2));

        Console.WriteLine(thing3 > thing2);



        Console.WriteLine("\n //------ С Т Р У К Т У Р Ы ------//\n");

        //здесь вызывается конструктор по умолчанию
        Person peter = new Person();

        Console.WriteLine("Name - " + peter.Name);
        Console.WriteLine("Age - " + peter.Age);

        peter.Name = "Peter";
        peter.Age = 20;

        //во время присваивания одной из структуры другой, копируются все данные
        Person ivan = peter;
        Console.WriteLine("Name - " + ivan.Name);
        Console.WriteLine("Age - " + ivan.Age);

        //после этого при изменнии одной структуры(значимый тип) данные другой не меняются, в отличии от классов(ссылочный тип)
        ivan.Name = "Ivan";
        ivan.Age = 22;
        Console.WriteLine("Name - " + peter.Name);
        Console.WriteLine("Age - " + peter.Age);

        //вызываем свой конструктор
        Person ivan2 = new Person("Ivan", 22);

        //инициализатор - позволяет инициализировать публичные данные в структурах и классах
        Person ivan3 = new Person { Name = "Ivan" };
        Person ivan4 = new Person { Name = "Ivan4", Age = 19 };

        // чтобы стравнить структуры используем метод Equals. Возвращает true, если все данные структур равны
        Console.WriteLine(ivan.Equals(ivan2));
        //в классах он возвращает true, если переменные ссылаются на один объект

        //создание структуры на основе другой с изменениями
        Person ivan5 = ivan4 with { Age = 25 };
        ivan5.Print();

        SetName(ivan5);
        ivan5.Print();
        SetName(ref ivan5);
        ivan5.Print();

    }

    //при передаче в метод структура копируется, и в нутри метода мы работаем с копией, а не с исходной структурой
    //и изменения не влияют на исходную структуру
    static void SetName(Person person)
    {
        person.Name = "New Name";
    }

    //при исползовании ref, in, out происходит ссылка на оришинальную структуру
    static void SetName(ref Person person)
    {
        //внутри мы работаем с оригинальной версией и изменения сохраняюся
        person.Name = "Vanya";
    }
}

