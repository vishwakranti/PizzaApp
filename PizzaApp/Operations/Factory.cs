using PizzaApp.Models;

namespace PizzaApp.Operations
{
    public static class Factory
    {

        public static PizzaBase GetAPizza(PizzaEnum pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaEnum.Vegatarian:
                    return new VegetarianPizza();
                case PizzaEnum.Chicken:
                    return new ChickenPizza();
                case PizzaEnum.Beef:
                    return new BeefPizza();
                default:
                    return new VegetarianPizza();


            }
        }
    }
}