namespace Lesson19;
class Program
{
    static void Main(string[] args)
    {
        Enemy enemy = new Enemy(0, 0, 30);
        enemy.Direction = new Vector2(1, 1);
        Bullet bullet = new Bullet(6, 3, 10, new Vector2(-1, 0));


        Block block1 = new Block(4, 3, 10);
        Block block2 = new Block(3, 3, 10);

        Wall wall1 = new Wall(0, 0);
        Wall wall2 = new Wall(8, 8);
        Wall wall3 = new Wall(0, 3);
        Wall wall4 = new Wall(6, 3);

        while(true)
        {
            Move(enemy, bullet);
            Collide(bullet, enemy, block1, block2, wall3, wall4);
            Collide(enemy, block1, block2, wall1, wall2);

            if (enemy.Health <= 0)
            {
                break;
            }

            Thread.Sleep(1000);
        }

        Console.WriteLine("--- GAME OVER ---");
    }

    static void Move(params IMovable[] movables)
    {
        foreach (var item in movables)
        {
            item.Move();
        }
    }

    static void Collide(ICollideble collideble, params GameObject[] targets)
    {
        foreach (var target in targets)
        {
            collideble.Collide(target);
        }
    }
}

