using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Components
{
    /// <summary>
    /// Component class represent cart summary.
    /// </summary>
    public class CartSummaryViewComponent : ViewComponent
    {
        private readonly Cart? cart;

        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }

        // Invoke cart object to view.
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
