namespace GpuFactory;

class Program
{
    public static void Main(string[] args) { 
    MsiManufacturer msiManufacturer = new MsiManufacturer();
        msiManufacturer.AssembleGpu();

    AsusManufacturer asusManufacturer = new AsusManufacturer();
        asusManufacturer.AssembleGpu();
    
    }
}