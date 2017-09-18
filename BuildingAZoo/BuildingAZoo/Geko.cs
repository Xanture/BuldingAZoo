using System;

namespace BuildingAZoo
{
    class Geko : Lizard
    {
        public override void Eat()
        {
            Console.WriteLine("Shoots tounge");
        }

        public override void Move()
        {
            Console.WriteLine("Sticky Feet!");
        }

        public override void Speak()
        {
            Console.WriteLine("Meeeow!");
        }
    }
}