using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class GamingComputerBuilder:ComputerBuilder
    {
        private Computer computer = new Computer();
        public void BuildCpu() { computer.CPU = "Intel Core i9";}
        public void BuildGpu() { computer.GPU = "NVIDIA RTX 3080"; }
        public void BuildStorage() { computer.Storage = 1000; }
        public void BuildRam() { computer.RAM = 32; }

        public Computer GetComputer()
        {
            return computer;
        }
    }
}
