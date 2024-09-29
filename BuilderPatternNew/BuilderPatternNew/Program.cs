
namespace BuilderPatternNew
    {
    class Program
    {
        static void Main(string[] args)
        {
          Car car = new CarBuilder()
            .Id(1)
            .Brand("Toyota")
            .Model("Corolla")
            .Color("White")
            .Build();

            car.DisplayCarDetails();
        }
    }
}
