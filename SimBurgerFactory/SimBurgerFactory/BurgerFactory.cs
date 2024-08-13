using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimBurgerFactory
{
    public class BurgerFactory
    {
        public Burger OrderBurger(string burgerType) {
           if(burgerType == null)
            {
                return null;
            }else if(burgerType == "chicken")
            {
                return new ChickenBurger();
            }else if (burgerType == "cheese")
            {
                return new CheeseBurger();
            }else if (burgerType == "veggie")
            {
                return new VeggieBurger();  
            }
            return null;
        }
    }
}
