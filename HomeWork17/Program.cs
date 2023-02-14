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

        Console.WriteLine(IsWater(h4));
        Console.WriteLine(IsWater(o1));

    }

    static bool IsWater( Hydrogen hydro)
    {
        if (hydro.Oxygen1 != null)
        {
            if (hydro.Oxygen1.Hidrogen1 != null && hydro.Oxygen1.Hidrogen2 != null )
            {
                if (hydro.Oxygen1.Hidrogen1 != hydro.Oxygen1.Hidrogen2)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        return false;
    }

    static bool IsWater(Oxygen oxy)
    {
        if (oxy.Hidrogen1 != null && oxy.Hidrogen2 != null)
        {
            if (oxy.Hidrogen2 != oxy.Hidrogen1)
            {
                return true;
            }
            return false;
        }
        return false;
    }
}

