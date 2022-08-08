namespace PizzaApp.Models
{
    public class BeefPizza : PizzaBase
    {
        public BeefPizza()
        {
            string[] ingredients = { "Beef", "Onion", "Cheese", "Chilli" };
            Ingredients.AddRange(ingredients);

            PizzaPrice.Add(new Tuple<PizzaSizeEnums, decimal>(PizzaSizeEnums.Small, 18.0m));
            PizzaPrice.Add(new Tuple<PizzaSizeEnums, decimal>(PizzaSizeEnums.Medium, 20.5m));
            PizzaPrice.Add(new Tuple<PizzaSizeEnums, decimal>(PizzaSizeEnums.Large, 24.0m));
        }

        public override void PizzaChefName(string name = "Elvis Presley")
        {
            base.PizzaChefName(name);
        }
    }
}
