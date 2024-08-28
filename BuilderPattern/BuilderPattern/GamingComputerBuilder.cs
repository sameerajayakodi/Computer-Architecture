using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class GamingComputerBuilder:ComputerBuilder
    {
        private Computer computer = new Computer();
        void BuildCpu() { computer.CPU = "Intel Core i9";}
        void BuildGpu() { computer.GPU = "NVIDIA RTX 3080"; }
        void BuildStorage() { computer.Storage = 1000; }
        void BuildRam() { computer.RAM = 32; }

        Computer GetComputer()
        {
            return computer;
        }
    }
}
