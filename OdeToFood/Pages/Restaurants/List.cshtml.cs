using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IRestaurantData data;
        public String Message;

        [BindProperty(SupportsGet =true)]
        public String SearchTerm { get; set; }

        public IEnumerable<Core.Restaurant> restaurants { get; set; }

        public ListModel(IRestaurantData data)
        {
            this.data = data;
        }


        public void OnGet()
        {
            restaurants = data.GetRestaurantByName(SearchTerm);
            Message = "This is a restaurant";
        }
    }
}
