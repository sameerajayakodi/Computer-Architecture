using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternNew
{
    public class ElectricCarBuilder: CarBuilder
    {
        Car car;
        public ElectricCarBuilder()
        {
            car = new Car();
        }

        public void BuildId()
        {
            car.setId(1);
        }

        public void BuildBrand()
        {
            car.setBrand("Tesla");
        }

        public void BuildModel()
        {
            car.setModel("Model S");
        }

        public void BuildColor()
        {
            car.setColor("Red");
        }

        public Car Build()
        {
            return car;
        }
    }
}
