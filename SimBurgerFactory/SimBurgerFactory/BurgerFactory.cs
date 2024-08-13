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
            Burger burger = null;
            if(burgerType == "chicken")
            {   
                burger = new ChickenBurger();
                burger.MakeBurger();
                

            }else if (burgerType == "cheese")
            {   
                burger = new CheeseBurger();
                burger.MakeBurger();
                
                
            }else if (burgerType == "veggie")
            {
                burger = new VeggieBurger();
                burger.MakeBurger();
                
            }
            return burger;
        }
    }
}
