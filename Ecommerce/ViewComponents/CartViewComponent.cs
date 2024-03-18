using Ecommerce.Helpers;
using Ecommerce.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.ViewComponents
{
    public class CartViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke() { 
            var cart = HttpContext.Session.Get<List<CartItem>>(MySetting.CART_KEY)?? new List<CartItem>();
            return View("CartPanel",new CartModelVM
            {
                Quantity = cart.Sum(p=>p.SoLuong),
                Total = cart.Sum(p=>p.ThanhTien)
            });
        }

    }
}
