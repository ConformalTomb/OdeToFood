using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class DetailsModel : PageModel
    {
        private readonly IRestaurantData data;
        public Restaurant Restaurant { get; set; }

        public DetailsModel(IRestaurantData data)
        {
            this.data = data;
        }

        public IActionResult OnGet(int restaurantId)
        {
            Restaurant = data.GetRestaurantById(restaurantId);

            if (Restaurant == null)
                return RedirectToPage("./NotFound");

            return Page();
        }
    }
}
