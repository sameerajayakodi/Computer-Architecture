namespace Prototype;

class Program
{
    public static void Main(string[] args)
    {
        Circle circlePrototype = new Circle("red",10);
        Circle c1 = (Circle)circlePrototype.Clone();
        circlePrototype.Draw();
        c1.Draw();
    }
}
