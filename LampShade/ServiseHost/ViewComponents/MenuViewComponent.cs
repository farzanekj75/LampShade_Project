using _01_LampshadeQuery.Contract.ProductCategory;
using Microsoft.AspNetCore.Mvc;

namespace ServiseHost.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
