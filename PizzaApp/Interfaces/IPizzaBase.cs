using PizzaApp.Models;

namespace PizzaApp.Interfaces
{
    public interface IPizzaBase
    {
        string PizzaChef { get; set; }
        string Name { get; set; }

        List<string> Ingredients { get; set; }
        List<Tuple<PizzaSizeEnums, decimal>> PizzaPrice { get; set; } 

        bool IsVegetarian { get; set; }

        bool IsGlutenFree { get; set; }
        void PizzaChefName(string name);


    }
}