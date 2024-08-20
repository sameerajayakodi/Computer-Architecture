using Singleton_Pattern;

class Program
{
    public static void Main(string[] args)
    {
        WashingMachine wm = WashingMachine.GetInstant();
        wm.GetMessage();
    }
}
