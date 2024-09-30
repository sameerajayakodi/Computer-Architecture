
namespace BuilderPatternNew
    {
    class Program
    {
        public static void Main(string[] args)
        {
          Car car = new Director(new ElectricCarBuilder()).Construct();
            car.Display();
            Console.WriteLine("-----------------------------------------------------");
         Car car1 = new Director(new GassolineCarBuilder()).Construct();
            car1.Display();
        }
    }
}
