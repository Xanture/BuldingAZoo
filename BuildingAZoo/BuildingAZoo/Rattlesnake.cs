using System;

namespace BuildingAZoo
{
    class Rattlesnake : Snake
    {
        public override void Eat()
        {
            Console.WriteLine("I'm pro at the snake game on Nokia");
        }

        public override void Move()
        {
            Console.WriteLine("Sneeeaky");
        }

        public override void Speak()
        {
            Console.WriteLine("I like to play the rattle!");
        }
    }
}
