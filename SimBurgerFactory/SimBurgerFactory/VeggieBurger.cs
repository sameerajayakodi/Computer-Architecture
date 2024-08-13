using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimBurgerFactory
{
    public class VeggieBurger:Burger
    {
        public override void MakeBurger()
        {
            Console.WriteLine("I am Making Veggie Burger...");
        }
    }
}
