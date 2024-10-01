using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    public class NormalComputer:ComputerBuilder
    {
        Computer computer;

        public NormalComputer()
        {
            computer = new Computer();
        }

        public void BuildCpu()
        {
            computer.setCpu("i5");
        }

        public void BuildRam()
        {
            computer.setRam("16GB");
        }

        public void BuildStorage()
        {
            computer.setStorage("512GB SSD");
        }

        public Computer Build()
        {
            return computer;
        }
    }
}
