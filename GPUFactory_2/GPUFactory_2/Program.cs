namespace GPUFactory_2;

class Program
{
    public static void Main(string[] args)
    {
        AsusManufacturer asusManufacturer = new AsusManufacturer();
        asusManufacturer.AssembleGpu();
        
        MsiManufacturer msiManufacturer = new MsiManufacturer();
        msiManufacturer.AssembleGpu();

    }
}

