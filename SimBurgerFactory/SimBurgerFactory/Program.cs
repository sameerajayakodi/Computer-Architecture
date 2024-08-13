namespace SimBurgerFactory;

class Progaram
{
    public static void Main(string[] args)
    {
        BurgerFactory burgerFactory = new BurgerFactory();
        burgerFactory.OrderBurger("veggie");
        burgerFactory.OrderBurger("chicken");
        burgerFactory.OrderBurger("cheese");
        
    }
}
