using PizzaApp.Interfaces;

namespace PizzaApp.Models
{
    public class PizzaBase : IPizzaBase
    {
        public string Name { get; set; }

        public string PizzaChef { get; set; }
        public List<string> Ingredients { get; set ; } = new List<string>();
        public bool IsVegetarian { get; set ; }
        public bool IsGlutenFree { get ; set; }
        public List<Tuple<PizzaSizeEnums, decimal>> PizzaPrice { get; set; } = new List<Tuple<PizzaSizeEnums, decimal>>();
        public string Image { get; set; }

        public string Description { get; set; }

        public virtual void PizzaChefName(string name = "Muhammad Ali")
        {
            PizzaChef = name;
        }
    }
}
