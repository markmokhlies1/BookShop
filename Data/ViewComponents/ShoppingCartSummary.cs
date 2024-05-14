using Book_Shop.Data.Card;
using Microsoft.AspNetCore.Mvc;

namespace Book_Shop.Data.ViewComponents
{
    public class ShoppingCartSummary
    {
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        //public IViewComponentResult Invoke()
        //{
        //    var items = _shoppingCart.GetShoppingCartItems();

        //    return View(items.Count);
        //}
    }
}
