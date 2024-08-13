using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GpuFactory
{
    public class MsiManufacturer:Company
    {
        public Gpu AssembleGpu() {
            Gpu gpu = CreateGpu();
            gpu.Assemble();
                return gpu;
        }
        public override Gpu CreateGpu()
        {
            return new MsiGpu();
        }
    }
}
