using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface ComputerBuilder
    {
        public void BuildCpu();
        public void BuildGpu();
        public void BuildStorage();
        public void BuildRam();

       public Computer GetComputer();
    }
}
