namespace HomeWork15;
class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Elina", 19);
        person1.AddPet(new Pet("Pup",  PetType.Cat , 7));
        person1.AddPet(new Pet("Buket", PetType.Dog, 19));
        person1.AddPet(new Pet("Kirusha", PetType.Cat));

        PrintInfo(person1);

        Person person2 = new Person("Tania", 14);
        person2.AddPet(new Pet("Grey", PetType.Dog, 33));
        person2.AddPet(new Pet("Dusia", PetType.Cat, 4));
        person2.RemovePet("Grey");

        PrintInfo(person2);
    }

    static void PrintInfo(Person person)
    {
        Console.WriteLine($"{person.Name}, {person.Age} years. Has {person.NumberOfPets} pets.");
        int weightOfAllPets = 0;
        int count = 0;
        for (int i = 0; i < person.NumberOfPets; i++)
        {
            //использовать getAllPets!!! для работы с массивом Pets
            if (person.Pets[i].Weight == 0)
            {
                Console.WriteLine($"{i + 1} - {person.Pets[i].Type}" +
                    $" {person.Pets[i].Name}, weight is unknown.");
                count++;
            }
            else
            {
                Console.WriteLine($"{i + 1} - {person.Pets[i].Type}" +
                    $" {person.Pets[i].Name}, weight is {person.Pets[i].Weight} kg.");
                weightOfAllPets += person.Pets[i].Weight;
            }
        }
        if (count == person.NumberOfPets )
        {
            weightOfAllPets = 0;
            Console.WriteLine("Total weight: unknown.");
        }
        else
        {
            Console.WriteLine($"Total weight: {weightOfAllPets} kg.");
        }
        Console.WriteLine();
    }
}

