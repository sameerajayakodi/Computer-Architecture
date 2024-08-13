using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GpuFactory
{
    public class AsusManufacturer:Company
    {
        public Gpu AssembleGpu()
        {
            Gpu gpu = CreateGpu();
            gpu.Assemble();
            return gpu;
        }
        public override Gpu CreateGpu()
        {
            return new AsusGpu();
        }

        public Monitor AssembleMonitor()
        {
            Monitor monitor = CreateMonitor();
            monitor.Assemble();
            return monitor;
        }

        public override Monitor CreateMonitor()
        {
            return new AsusMonitor();
        }
    }
}
