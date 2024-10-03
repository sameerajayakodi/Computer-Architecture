namespace ComputerBuilder
{
    class Program
    {
        public static void Main(string[] args)
        {
           Computer computer = new Director(new GamingComputer()).Construct();
            computer.Display();
        }
    }
}