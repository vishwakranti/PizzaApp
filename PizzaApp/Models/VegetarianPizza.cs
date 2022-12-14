namespace PizzaApp.Models
{
    public class VegetarianPizza : PizzaBase
    {
        public VegetarianPizza()
        {
            string[] ingredients = {"Capsicum", "Tomato" , "Spinach", "Mushrooms", "Onion"};
            Ingredients.AddRange(ingredients);

            PizzaPrice.Add(new Tuple<PizzaSizeEnums,decimal> (PizzaSizeEnums.Small,15.5m));
            PizzaPrice.Add(new Tuple<PizzaSizeEnums, decimal>(PizzaSizeEnums.Medium, 17.5m));
            PizzaPrice.Add(new Tuple<PizzaSizeEnums, decimal>(PizzaSizeEnums.Large, 19.5m));

            PizzaChefName("Justin Beiber");

            Image = "VegPizza.JPG";
            IsGlutenFree = false;
            IsVegetarian = true;
            Description = "Vegetarian Pizza has a cheese base";
        }

        public override void PizzaChefName(string name = "Justin Beiber")
        {
            base.PizzaChefName(name);
        }


    }
}
