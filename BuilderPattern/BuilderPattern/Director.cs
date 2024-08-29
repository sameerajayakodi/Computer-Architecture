using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Director
    {
        private ComputerBuilder _builder;

        public Director(ComputerBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructComputer()
        {
            _builder.BuildCpu();
            _builder.BuildGpu();
            _builder.BuildRam();
            _builder.BuildStorage();
        }
    }
}
