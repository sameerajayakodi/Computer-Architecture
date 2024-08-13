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
                ChickenBurger burger = new ChickenBurger();
                burger.MakeBurger();
                return burger;

            }else if (burgerType == "cheese")
            {   
                CheeseBurger burger = new CheeseBurger();
                burger.MakeBurger();
                return burger;
                
            }else if (burgerType == "veggie")
            {
                VeggieBurger burger = new VeggieBurger();
                burger.MakeBurger();
                return burger;  
            }
            return null;
        }
    }
}
