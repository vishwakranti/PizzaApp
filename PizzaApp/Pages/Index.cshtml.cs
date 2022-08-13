using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaApp.Models;
using PizzaApp.Operations;
using System.ComponentModel.DataAnnotations;

namespace PizzaApp.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        public string ImagePath { get; set; }

        public List<string> ImagePathList { get; set; }

        public IndexModel()
        {
            //ImagePathList = new List<string>();
            //ImagePathList.Add("chicken.jpg");
            //ImagePathList.Add("VegPizza.jpg");
            //ImagePathList.Add("BeefPizza.jpg");
           
        }
        public bool FirstLoad { get; set; }

        [Display(Name = "Pizza Type")]
        public string PizzaType { get; set; }

        public PizzaBase Pizza { get; set; }

        public void OnGet()
        {
            FirstLoad = true;

        }

        public void OnPost()
        {
            var pizzaType = Convert.ToInt32(Request.Form["PizzaType"]);

            FirstLoad = false;

            Pizza = Factory.GetAPizza((PizzaEnum)pizzaType);
            
        }
    }
}