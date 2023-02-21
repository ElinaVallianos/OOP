namespace Lesson19;
class Program
{
    static void Main(string[] args)
    {
        Enemy enemy = new Enemy(0, 0, 30);
        enemy.Direction = new Vector2(1, 1);
        Bullet bullet = new Bullet(6, 3, 10, new Vector2(-1, 0));

        while(true)
        {
            Move(enemy, bullet);

            Thread.Sleep(1000);
        }
    }

    static void Move(params IMovable[] movables)
    {
        foreach (var item in movables)
        {
            item.Move();
        }
    }
}

