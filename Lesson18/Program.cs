namespace Lesson18;
class Program
{
    static void Main(string[] args)
    {
        // Н А С Л Е Д О В А Н И Е 

        Car car = new Car(4);
        Bus bus = new Bus(20);
        Track track = new Track(3, 1000);
        Plane plane = new Plane(2);

        //переменная типа базового класса может хранить значения типа класса наследника.
        Transport transport = car;
        transport.Speed = 22;
        //через переменную базового класса можно обращаться только к тем членам,
        //которые объявленны в базовом классе.
        //transport.Move(); --- так нельзя  ОШИБКА
        //приводим переменную типа transport к типу car и получаем доступ к методу Move().
        ((Car)transport).Move();

        SetSpeed(car, 20);
        SetSpeed(bus, 40);
        SetSpeed(track, 80);
        SetSpeed(plane, 200);

        bus.Route = 12;
        bus.Passengers = 12;
        bus.Move();
        track.Move();
        plane.Altitude = 500;
        plane.Fly();

    }

    // параметр типа базового класса может принимать значения типа класса наследника
    static void SetSpeed(Transport transport, int speed)
    {
        transport.Speed = speed;
    }
}

