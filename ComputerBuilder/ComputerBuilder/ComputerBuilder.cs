using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    public interface ComputerBuilder
    {
        public void BuildCpu();
        public void BuildRam();
        public void BuildStorage();

        public Computer Build();
    }
}
