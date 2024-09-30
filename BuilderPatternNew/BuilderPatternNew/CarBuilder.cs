using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternNew
{
    public interface CarBuilder
    {
        public void BuildId();
        public void BuildBrand();
        public void BuildModel();
        public void BuildColor();
        public Car Build();
    }
}
