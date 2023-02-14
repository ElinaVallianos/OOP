namespace HomeWork17;
class Program
{
    static void Main(string[] args)
    {
        Hydrogen h1 = new Hydrogen();
        Hydrogen h2 = new Hydrogen();
        Hydrogen h3 = new Hydrogen();
        Hydrogen h4 = new Hydrogen();
        Oxygen o1 = new Oxygen();
        Oxygen o2 = new Oxygen();
        Oxygen o3 = new Oxygen();

        h1.React(o1);
        o2.React(h2);
        o1.React(h3);
        h4.React(o1);
        o3.React(h4);

        string answer = IsWater(h4) ? "" : "not";
        Console.WriteLine($" 'h4' is {answer} in water molecule.");
        answer = IsWater(o1) ? "" : "not";
        Console.WriteLine($" 'o1' is {answer} in water molecule.");

    }

    static bool IsWater( Hydrogen hydro)
    {
        if (hydro.Oxygen1 != null)
        {
            return IsWater(hydro.Oxygen1);
        }
        return false;
    }

    static bool IsWater(Oxygen oxy)
    {
        if (oxy.Hidrogen1 == null || oxy.Hidrogen2 == null)
        {
            return false;
        }
        return true;
    }
}

