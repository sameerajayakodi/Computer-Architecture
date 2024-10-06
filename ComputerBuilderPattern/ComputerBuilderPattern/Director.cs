using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilderPattern
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
            computerBuilder.BuildProcessor();
            computerBuilder.BuildRam();
            computerBuilder.BuildStorage();
            computerBuilder.BuildGraphicCard();
            computerBuilder.BuildPowerSupply();
            computerBuilder.BuildOs();
            return computerBuilder.Build();
        }
    }
}
