namespace GpuFactory;

class Program
{
    public static void Main(string[] args) { 
    MsiManufacturer msiManufacturer = new MsiManufacturer();
        msiManufacturer.AssembleGpu();
        msiManufacturer.AssembleMonitor();

    AsusManufacturer asusManufacturer = new AsusManufacturer();
        asusManufacturer.AssembleGpu();
        msiManufacturer.AssembleMonitor();
    
    }
}