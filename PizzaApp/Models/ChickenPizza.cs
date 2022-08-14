namespace PizzaApp.Models
{
    public class ChickenPizza : PizzaBase
    {

        public ChickenPizza()
        {
            string[] ingredients = { "Chicken", "Cheese", "Onion", "Red Chilli" };
            Ingredients.AddRange(ingredients);

            PizzaPrice.Add(new Tuple<PizzaSizeEnums, decimal>(PizzaSizeEnums.Small, 17.5m));
            PizzaPrice.Add(new Tuple<PizzaSizeEnums, decimal>(PizzaSizeEnums.Medium, 19.5m));
            PizzaPrice.Add(new Tuple<PizzaSizeEnums, decimal>(PizzaSizeEnums.Large, 22.5m));

            PizzaChefName("Michael Jackson");
            Image = "chicken.JPG";
            IsGlutenFree = true;
            IsVegetarian = false;
            Description = "Chicken Pizza has a very thick crust with cheese";

        }
        public override void PizzaChefName(string name)
        {
            base.PizzaChefName(name);
        }
    }
}
