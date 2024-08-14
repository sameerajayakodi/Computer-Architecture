using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPUFactory_2
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
    }
}
