namespace SimpleFactory;


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(".............Starting Shape Factory..........");

        ShapeFactory factory = new ShapeFactory();
        Shape shape1 =  factory.GetShape("squre");
        shape1.Drow();

        Shape shape2 = factory.GetShape("circle");
        shape2.Drow();

        Shape shape3 = factory.GetShape("rectangle");
        shape3.Drow(); 
    }

}