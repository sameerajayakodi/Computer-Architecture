using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface ComputerBuilder
    {
        void BuildCpu();
        void BuildGpu();
        void BuildStorage();
        void BuildRam();

        Computer GetComparer();
    }
}
