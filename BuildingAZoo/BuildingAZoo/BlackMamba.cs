using System;

namespace BuildingAZoo
{
    class BlackMamba : Snake
    {
        public override void Eat()
        {
            Console.WriteLine("Chomp Chomp Chomp");
        }

        public override void Move()
        {
            Console.WriteLine("Slithhhhhhher");
        }

        public override void Speak()
        {
            Console.WriteLine("Mooooo!");
        }
    }
}
