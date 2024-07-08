using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Components
{
    // ViewComponent to generate the navigation menu
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IStoreRepository repository;

        // Constructor that initializes the repository
        public NavigationMenuViewComponent(IStoreRepository repo)
        {
            repository = repo;
        }

        // Method to invoke the ViewComponent
        public IViewComponentResult Invoke()
        {
            // Set the selected category in the ViewBag from the route data
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            // Return the view with distinct categories from the repository, ordered by category name
            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
