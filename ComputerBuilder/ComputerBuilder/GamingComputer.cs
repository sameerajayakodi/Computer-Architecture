using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    public class GamingComputer: ComputerBuilder
    {
        Computer computer;

        public GamingComputer()
        {
            computer = new Computer();
        }

        public void BuildCpu()
        {
            computer.setCpu("i9");
        }

        public void BuildRam()
        {
            computer.setRam("32GB");
        }

        public void BuildStorage()
        {
            computer.setStorage("1TB SSD");
        }

        public Computer Build()
        {
            return computer;
        }
    }
}
