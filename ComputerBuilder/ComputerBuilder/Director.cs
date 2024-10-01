using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    public class Director
    {
        ComputerBuilder computerBuilder;

        public Director(ComputerBuilder computerBuilder)
        {
            this.computerBuilder = computerBuilder;
        }

        public Computer Construct()
        {
            computerBuilder.BuildCpu();
            computerBuilder.BuildRam();
            computerBuilder.BuildStorage();

            return computerBuilder.Build();
        }
    }
}
