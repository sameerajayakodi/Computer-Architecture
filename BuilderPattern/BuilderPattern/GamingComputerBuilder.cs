using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class GamingComputerBuilder:ComputerBuilder
    {
        private Computer _computer = new Computer();
        public void BuildCpu() { _computer.CPU = "Intel Core i9";}
        public void BuildGpu() { _computer.GPU = "NVIDIA RTX 3080"; }
        public void BuildStorage() { _computer.Storage = 1000; }
        public void BuildRam() { _computer.RAM = 32; }

        public Computer GetComputer()
        {
            return _computer;
        }
    }
}
