using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilderPattern
{
    public class WorkComputerBuilder : ComputerBuilder
    {
        Computer computer;

        public WorkComputerBuilder()
        {
            computer = new Computer();
        }

        public void BuildProcessor()
        {
            computer.setProcessor("Intel Core i5-1100H");
        }

        public void BuildRam()
        {
            computer.setRam("Samsung 16GB");
        }

        public void BuildStorage()
        {
            computer.setStorage("Samsung 500GB");
        }

        public void BuildGraphicCard()
        {
            computer.setGraphicsCard("Nvidia GeForce GTX 1660");
        }

        public void BuildPowerSupply()
        {
            computer.setPowerSupply("Corsair 650");
        }

        public void BuildOs()
        {
            computer.setOS("Windows 10 Home");
        }

        public Computer Build()
        {
            return computer;
        }
    }
}
