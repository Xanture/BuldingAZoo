using System;

namespace BuildingAZoo
{
    class CornSnake : Snake
    {
        public override void Eat()
        {
            Console.WriteLine("nom nom nom");
        }

        public override void Move()
        {
            Console.WriteLine("I only move if there is corn around");
        }

        public override void Speak()
        {
            Console.WriteLine("Woof!");
        }
    }
}
