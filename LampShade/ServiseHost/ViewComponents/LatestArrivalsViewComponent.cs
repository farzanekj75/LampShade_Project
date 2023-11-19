using _01_LampshadeQuery.Contract.Product;
using _01_LampshadeQuery.Contract.ProductCategory;
using Microsoft.AspNetCore.Mvc;

namespace ServiseHost.ViewComponents
{
    public class LatestArrivalsViewComponent : ViewComponent
    {
         private readonly IProductQuery _productQuery;

        public LatestArrivalsViewComponent(IProductQuery productQuery)
        {
            _productQuery = productQuery;
        }
        public IViewComponentResult Invoke()
        {
            var products = _productQuery.GetLatestArrivals();
            return View(products);
        }
    }
}
