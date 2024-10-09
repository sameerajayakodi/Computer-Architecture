namespace PrototypeDesignPattern;

class Program
{
    static void Main(string[] args)
    {
       Circle circlePrototype = new Circle("Red");
        Circle circle1 = (Circle)circlePrototype.Clone();
        circle1.Drow();
        circlePrototype.Drow();
    }
}