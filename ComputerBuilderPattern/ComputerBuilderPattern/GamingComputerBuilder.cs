using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilderPattern
{
    public class GamingComputerBuilder: ComputerBuilder
    {
         Computer computer;

        public GamingComputerBuilder()
        {
            computer = new Computer();
        }

        public void BuildProcessor()
        {
            computer.setProcessor("Intel Core i9-9900K");
        }

        public void BuildRam()
        {
            computer.setRam("MSI 64GB");
        }

        public void BuildStorage()
        {
            computer.setStorage("MSI 4TB");
        }

        public void BuildGraphicCard()
        {
            computer.setGraphicsCard("Nvidia GeForce RTX 4090");
        }

        public void BuildPowerSupply()
        {
            computer.setPowerSupply("Corsair 1150");
        }

        public void BuildOs()
        {
            computer.setOS("Windows 10 Pro");
        }

        public Computer Build()
        {
            return computer;
        }
    }
}
