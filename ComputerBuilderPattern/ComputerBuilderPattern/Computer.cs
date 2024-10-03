using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilderPattern
{
    public class Computer
    {
        private string processor;
        private string ram;
        private string storage;
        private string graphicsCard;
        private string powerSupply;
        private string os;

        public void setProcessor(string processor)
        {
            this.processor = processor;
        }

        public void setRam(string ram)
        { 
            this.ram = ram;
        }

        public void setStorage(string storage)
        {
            this.storage = storage; 
        }

        public void setGraphicsCard(string graphicsCard)
        {
            this.graphicsCard = graphicsCard;
        }

        public void setPowerSupply(string powerSupply)
        {
            this.powerSupply = powerSupply;
        }

        public void setOS(string os)
        {
            this.os = os;
        }

        public void Display()
        {
            Console.WriteLine("Processor: " + processor);
            Console.WriteLine("RAM: " + ram);
            Console.WriteLine("Storage: " + storage);
            Console.WriteLine("Graphics Card: " + graphicsCard);
            Console.WriteLine("Power Supply: " + powerSupply);
            Console.WriteLine("OS: " + os);
        }
    }
}
