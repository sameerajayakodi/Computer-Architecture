using Singleton_Pattern;

class Program
{
    public static void Main(string[] args)
    {
        WashingMachine washingMachine = WashingMachine.GetInstance();
        washingMachine.ShowMessage();
    }
}
