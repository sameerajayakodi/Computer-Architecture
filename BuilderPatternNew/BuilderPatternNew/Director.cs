using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternNew
{
    public class Director
    {
        CarBuilder carBuilder;

        public Director(CarBuilder carBuilder)
        {
            this.carBuilder = carBuilder;
        }

        public Car Construct()
        {
            carBuilder.BuildId();
            carBuilder.BuildBrand();
            carBuilder.BuildModel();
            carBuilder.BuildColor();

            return carBuilder.Build();
        }
    }
}
