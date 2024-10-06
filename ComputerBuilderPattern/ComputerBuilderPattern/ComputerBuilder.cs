using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilderPattern
{
    public interface ComputerBuilder
    { 
        public void BuildProcessor();
        public void BuildRam();
        public void BuildStorage();
        public void BuildGraphicCard();

        public void BuildPowerSupply();
        public void BuildOs();
        
        public Computer Build();
    }
}
