using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternNew
{
    public class GassolineCarBuilder:CarBuilder
    {
        Car car;

        public GassolineCarBuilder()
        {
            car = new Car();
        }

        public void BuildId()
        {
            car.setId(2);
        }

        public void BuildBrand()
        {
            car.setBrand("Ford");
        }

        public void BuildModel()
        {
            car.setModel("Mustang");
        }
        
        public void BuildColor()
        {
            car.setColor("Blue");
        }
        public Car Build() 
        {
            return car;
        }
    }
}
