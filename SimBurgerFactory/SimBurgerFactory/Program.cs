namespace SimBurgerFactory;

class Progaram
{
    public static void Main(string[] args)
    {
        BurgerFactory burgerFactory = new BurgerFactory();
         Burger burger1 = burgerFactory.OrderBurger("veggie");
        burger1.MakeBurger();

        Burger burger2 = burgerFactory.OrderBurger("chicken");
        burger2.MakeBurger();

        Burger burger3 = burgerFactory.OrderBurger("cheese");
        burger3.MakeBurger();
    }
}
