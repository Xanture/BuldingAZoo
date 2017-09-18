namespace BuildingAZoo
{
    abstract class Reptiles : Animals
    {
        public  bool IsColdBlooded = true;
        public abstract void Move();
        public abstract void Speak();
    }
}
