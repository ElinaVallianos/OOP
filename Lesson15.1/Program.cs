namespace Lesson15._1;

//обектно ориентированное программирование
//ООП:
// - Абстракция
// - Инкапсуляция
// - Наследование
// - Полиморфизм
class Program
{
    static void Main(string[] args)
    {
        //объект - это экземпляр класса
        //для создания объекта вызывается конструктор класса после слова new
        MyClass myClass = new MyClass();
        MyClass myClass1 = new MyClass("Class1");

        //задаем свойства объекта myClass1
        myClass1.Number = 12;
        //получаем значение свойства Name
        string nameOfClass1 = myClass1.Name;

        myClass.Print();
        myClass1.Print();

        Library library = new Library("Blok", 15);
        Book book = new Book("Homer", "Iliad", 333);

        Library library1 = library;
        //переменная типа класса - это ссылка на другой объект

        library.AddNewBook(book);
        library.AddNewBook(new Book("Adms", "Tommy", 234));
        library.AddNewBook(new Book("Homer", "Odissey", 564));
        library.AddNewBook(new Book("Poul", "Tom & Gek", 312));

        library.FindByTitle("tom");

        if (library.GetBook(3, ref book))
        {
            Console.WriteLine(book.Library.Name);
            Console.WriteLine(book.GetInfo());
        }


    }
}

//класс - это структура данных, обединяющая поля (данные) и методы
//класс - это определение (шаблон) для экземпляров класса (объектов) 
public class MyClass
{
    //поля - это данные класса
    private string name = "New Class"; //значение по умолчанию
    private int number;

    //свойства - методы(работают как они) для доступа к полям
    public string Name { get => name; set => name = value; }
    public int Number { get => number; set => number = value; }

    //конструктор - метод для создания экземпляра класса
    //конструкторов может быть несколько (перегрузка методов)
    public MyClass()
    {

    }

    public MyClass(string newName)
    {
        name = newName;
    }

    public MyClass(string newName, int number)
    {
        name = newName;
        //this. - это ссылка на текущий класс
        this.number = number;
    }

    //методы класса
    public void Print()
    {
        Console.WriteLine($"Class {name} number {number}");
    }
}
