using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaApp.Models;
using System.ComponentModel.DataAnnotations;

namespace PizzaApp.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        public bool FirstLoad { get; set; }

        [Display(Name = "Pizza Type")]
        public string PizzaType { get; set; }

        public PizzaBase Pizza { get; set; }

        public void OnGet()
        {
            FirstLoad = false;

        }

        public void OnPost()
        {

        }
    }
}