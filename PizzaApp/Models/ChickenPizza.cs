namespace PizzaApp.Models
{
    public class ChickenPizza : PizzaBase
    {
        public new string Image { get; set; } = "chicken.JPG";

        public ChickenPizza()
        {
            string[] ingredients = { "Chicken", "Cheese", "Onion", "Red Chilli" };
            Ingredients.AddRange(ingredients);

            PizzaPrice.Add(new Tuple<PizzaSizeEnums, decimal>(PizzaSizeEnums.Small, 17.5m));
            PizzaPrice.Add(new Tuple<PizzaSizeEnums, decimal>(PizzaSizeEnums.Medium, 19.5m));
            PizzaPrice.Add(new Tuple<PizzaSizeEnums, decimal>(PizzaSizeEnums.Large, 22.5m));

            PizzaChefName("Michael Jackson");
        }
        public override void PizzaChefName(string name)
        {
            base.PizzaChefName(name);
        }
    }
}
