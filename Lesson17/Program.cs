using Lesson17a;
namespace Lesson17;


class Program
{
    static void Main(string[] args)
    {
        Wagon wagonRest = new Wagon(WagonType.Reastaurant);
        Wagon wagonCupe = new Wagon(WagonType.Cupe);
        Wagon wagonLux = new Wagon(WagonType.Lux);

        Train train = new Train();

        for (int i = 0; i < 5; i++)
        {
            train.AddWagon(new Wagon(WagonType.Cupe));
        }

        train.AddWagon(wagonLux, 4);
        train.RemoveWagon(2);

        ReplaceWagon(train.GetWagon(2), wagonRest);
        ReplaceWagon(train.GetWagon(7), new Wagon(WagonType.Reastaurant));
        train.Print();

        Wagon2 wagon2;
    }

    static void ReplaceWagon(Wagon? oldW, Wagon? newW)
    {
        if (oldW == null || newW == null) return;
        var prevW = oldW.Prev;
        var nextW = oldW.Next;
        newW.Prev = prevW;
        newW.Next = nextW;

        if (nextW == null) nextW.Prev = newW;
        if (prevW == null) prevW.Prev = newW;

    }


}

