namespace BuilderPattern;

class Program
{
    public static void Main(string[] args)
    {
        ComputerBuilder builder = new GamingComputerBuilder();
        Director director = new Director(builder);
        director.ConstructComputer();
        Computer gamingComputer = builder.GetComputer();
        Console.WriteLine(gamingComputer.ToString());
    }
}