using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using ShopManagement.Appilication;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Application.Contracts.ProductPicture;
using System.Collections.Generic;

namespace ServiseHost.Areas.Administration.Pages.Shop.ProductPictures
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public ProductPictureSearchModel SearchModel;
        public List<ProductPictureViewModel> ProductPictures;
        public SelectList Products;

        private readonly IProductApplication _productAppilcation;
        private readonly IProductPictureApplication _productPictureAppilcation;

        public IndexModel(IProductApplication productAppilcation ,
            IProductPictureApplication productPictureAppilcation)
        {
            _productAppilcation = productAppilcation;
            _productPictureAppilcation = productPictureAppilcation;
        }

        public void OnGet(ProductPictureSearchModel searchModel)
        {
            Products = new SelectList(_productAppilcation.GetProducts(),"Id","Name");
            ProductPictures = _productPictureAppilcation.Search(searchModel);
        }
        public IActionResult OnGetCreate()
        {
            var command = new CreateProductPicture
            {
               Products = _productAppilcation.GetProducts()
            };
            return Partial("./Create", command);
        }
        public JsonResult OnPostCreate(CreateProductPicture command)
        {
            var result = _productPictureAppilcation.Create(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetEdit(long id)
        {
            var productPicture = _productPictureAppilcation.GetDetails(id);
            productPicture.Products = _productAppilcation.GetProducts();
            return Partial("Edit", productPicture);
        }
        public JsonResult OnPostEdit(EditProduct command)
        {
            var result = _productAppilcation.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetRemove(long id)
        {
            var result = _productPictureAppilcation.Remove(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }
        public IActionResult OnGetRestore(long id)
        {
           var result = _productPictureAppilcation.Restore(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
