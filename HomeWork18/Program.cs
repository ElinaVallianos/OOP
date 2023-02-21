namespace HomeWork18;
class Program
{
    static void Main(string[] args)
    {
        //DATABASE OF ANIMALS AND THEIR LIFE

        Canine dog = new Canine("Moscow", 4, 43);
        Wolf wolf1 = new Wolf("European woods",12, 76);
        Wolf wolf2 = new Wolf("European woods", 5,63);
        Fish fish = new Fish("River",2);
        Fox fox = new Fox("Countryside",3,33, 4);

        Creature waterCreature = fish;
        waterCreature.Food = "water plants";
        fish.Depth = 10;
        fish.Length = 12;

        wolf1.Food = "Dears";
        wolf1.Status = Status.Alfa;
        wolf1.Sex = Sex.Male;
        wolf1.Puppies = 3;

        wolf2.Sex = Sex.Female;
        wolf2.Puppies = 4;
        wolf2.Status = Status.Betta;
        wolf2.Food = "Rabbits and birds";

        dog.Food = "Pedigry";

        fox.Food = "Chikens, rabbits and mouse";

        wolf2.GetInfo();
        wolf2.GetLifeInfo();
        wolf1.GetLifeInfo();
        fox.GetLifeInfo();

        fish.GetLength();

        dog.GetInfo();
    }
}

