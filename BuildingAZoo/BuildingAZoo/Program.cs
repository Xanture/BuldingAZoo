using System;

namespace BuildingAZoo
{
    class Program
    {

        static void Main(string[] args)
        {
            Rattlesnake sammyTheSnake = new Rattlesnake();
            sammyTheSnake.Eat();
            sammyTheSnake.Move();
            Console.WriteLine(sammyTheSnake.IsColdBlooded);
            Console.Read();
        }
    }
}
