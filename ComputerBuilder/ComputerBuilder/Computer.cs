using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    public class Computer
    {
       // cpu , ram , storage

        private string cpu;
        private string ram;
        private string storage;


        public void setCpu(string cpu)
        {
            this.cpu = cpu;
        }

        public void setRam(string ram)
        {
            this.ram = ram;
        }

        public void setStorage(string storage)
        {
            this.storage = storage;
        }

        public void Display()
        {
            Console.WriteLine("CPU: " + cpu);
            Console.WriteLine("RAM: " + ram);
            Console.WriteLine("Storage: " + storage);
        }
    }
}
