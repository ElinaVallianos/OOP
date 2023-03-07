namespace HomeWork20;
class Program
{
    static void Main(string[] args)
    {
        Bird bird = new Bird(0, 0, 30);
        bird.Direction = new Vector(0, 1);

        Wall wall1 = new Wall(1, 7);
        Wall wall2 = new Wall(6, 6);
        Wall wall3 = new Wall(5, 5);
        Wall wall4 = new Wall(2, 2);

        int[][] positions = new int[6][];

        positions[0] = new int[] { 1, 4 };
        positions[1] = new int[] { 4, 6 };
        positions[2] = new int[] { 5, 4 };
        positions[3] = new int[] { 4, 2 };
        positions[4] = new int[] { 3, 2 };
        positions[5] = new int[] { 3, 4 };

        Random rnd = new Random();
        foreach (var position in positions) // можно ли так объявлять объекты?? 
        {
            int random = rnd.Next(1);
            switch (random)
            {
                case 0:
                    Poison poison = new Poison(position[0], position[1], 15);
                    break;
                default:
                    Apple apple = new Apple(position[0], position[1], 10);
                    break;
            }
        }

        while (true)
        {
            Move(bird);
            Interaction(bird, wall1, wall2, wall3, wall4); // как взаимодействовать с apple и poison, если они были объявленны без имён???

            if (bird.Health == 0)
            {
                Console.WriteLine("The Bird was poisoned.");
                break; 
            }
            if (bird.Position.X == 3 && bird.Position.Y == 4)
            {
                Console.WriteLine("The Bird survived.");
                break;
            }

            Thread.Sleep(1000);
        }
        Console.WriteLine("--- GAME OVER ---");
    }
    static void Move(IMovable bird)
    {
        bird.Move();
    }

    static void Interaction(IInteractional movable, params GameObject[] targets) // bird не меняет своего направления  и не взаимодействует с Wall (?)
    {
        foreach (var target in targets)
        {
            movable.Interact(target);
        }
    }
}

