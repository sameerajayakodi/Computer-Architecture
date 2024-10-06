namespace ComputerBuilderPattern;

class Program
{
    static void Main(string[] args)
    {
        Computer gamingComputer = new Director(new GamingComputerBuilder()).Construct();
        gamingComputer.Display();

        Console.WriteLine("------------------------------------------------------------");
        Computer workingComputer = new Director(new WorkComputerBuilder()).Construct();
        workingComputer.Display();
    }
}
