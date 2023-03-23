
namespace Lesson8
{
    abstract class Transport
    {
        public abstract int Speed { get; set; }
        public abstract void Move();
        public abstract void Stop();
    }

    class Car : Transport
    {
        public override int Speed { get; set; } = 60;

        public override void Move() { Console.WriteLine("Car moving"); }
        public override void Stop() { Console.WriteLine("Car stop"); }
    }

    class Plane : Transport
    {
        public override int Speed { get; set; } = 240;

        public override void Move() { Console.WriteLine("Plane moving"); }
        public override void Stop() { Console.WriteLine("Plane stop"); }
    }

    class Train : Transport
    {
        public override int Speed { get; set; } = 100;

        public override void Move() { Console.WriteLine("Train moving"); }
        public override void Stop() { Console.WriteLine("Train stop"); }
    }

}
