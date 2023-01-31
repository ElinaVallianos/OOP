namespace Lesson16;
class Program
{
    static void Main(string[] args)
    {
        Person petya = new Person("Petya");
        // ссылочные переменные представляют соблй ссылку на объект
        // null - это отсутствие сылки на объект

        if ( petya.Parent1 != null)
        {
            Console.WriteLine($"{petya.Parent1.Name} is {petya.Name}'s parent.");
        }

        // вопросительный знак значит, что значение вернется только если значение Parent1 не равен null.
        // если Parent1 == null, то вернется null.
        Console.WriteLine($"{petya.Parent1?.Name} is {petya.Name}'s parent.");

        string parent = petya.Parent1?.Name;
        Console.WriteLine(parent?.Length);

        Person mike = new Person("Mike");
        Person kate = new Person("Kate");
        petya.Parent1 = mike;
        petya.Parent2 = kate;
        Console.WriteLine($"{petya.Parent1?.Name} is {petya.Name}'s parent.");
        Console.WriteLine($"{petya.Parent2?.Name} is {petya.Name}'s parent.");
        // односвязный список

        Person sophia = new Person("Sophia");
        sophia.Parent1 = mike;
        sophia.Parent2 = kate;

        // если сравниваем ссылочные переменные, то проверяется только то, что они ссылаются на один объект.
        if (petya.Parent1 == sophia.Parent1)
        {
            Console.WriteLine($"{petya.Name} and {sophia.Name} are family.");

        }

        sophia.Parent1.Name = "Bob";
        Console.WriteLine($"{petya.Parent1?.Name} is {petya.Name}'s parent.");

        Rename(sophia, "Nina");
        Console.WriteLine($"{sophia.Name}");

        petya = mike;

        CheckParents(petya, ref mike);
        Console.WriteLine($"{petya.Name} - {mike?.Name}?");

        petya.Parent1 = petya;

        Rectangle rectangle = new Rectangle(12, 13, 2, 1);
        Console.WriteLine(rectangle.Square);

    }


    // в метод передается ссылка на объект, и его внутренние данные можно изменить
    static void Rename(Person person, string newName)
    {
        person.Name = newName;
    }


    static void CheckParents( Person parent1, ref Person parent2)
    {
        if (parent1 == parent2) parent2 = null;
    }

    
}

