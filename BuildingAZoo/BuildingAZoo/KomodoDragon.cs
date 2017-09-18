using System;

namespace BuildingAZoo
{
    class KomodoDragon : Lizard
    {
        public override void Eat()
        {
            Console.WriteLine("I'm a vegitarian!");
        }

        public override void Move()
        {
            Console.WriteLine("Nope I just wanna sleep all day");
        }

        public override void Speak()
        {
            Console.WriteLine("I'm faaaabulous!!!!");
        }
    }
}
