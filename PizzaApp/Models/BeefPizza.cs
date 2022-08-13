namespace PizzaApp.Models
{
    public class BeefPizza : PizzaBase
    {
        public new string Image { get; set; } = "BeefPizza.JPG";
        public BeefPizza()
        {
            string[] ingredients = { "Beef", "Onion", "Cheese", "Chilli" };
            Ingredients.AddRange(ingredients);

            PizzaPrice.Add(new Tuple<PizzaSizeEnums, decimal>(PizzaSizeEnums.Small, 18.0m));
            PizzaPrice.Add(new Tuple<PizzaSizeEnums, decimal>(PizzaSizeEnums.Medium, 20.5m));
            PizzaPrice.Add(new Tuple<PizzaSizeEnums, decimal>(PizzaSizeEnums.Large, 24.0m));

            PizzaChefName("Elvis Presley");
        }

        public override void PizzaChefName(string name)
        {
            base.PizzaChefName(name);
        }
    }
}
