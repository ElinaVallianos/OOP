namespace HomeWork16;
class Program
{
    static void Main(string[] args)
    {
        Train train1 = new Train();

        for (int i = 0; i < 5; i++)
        {
            train1.AddWagon(WagonType.Cupe);
        }
        train1.AddWagon(4, WagonType.Lux);
        train1.DeleteWagon(2);


        train1.Print();
    }

    //static void RemoveWagon( Wagon currentWagon, Wagon newWagon)
    //{

    //}
}

