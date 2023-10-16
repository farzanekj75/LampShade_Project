using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Appilication;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductCategory;
using System.Collections.Generic;

namespace ServiseHost.Areas.Administration.Pages.Shop.Products
{
    public class IndexModel : PageModel
    {
        public ProductSearchModel SearchModel;
        public List<ProductViewModel> Products;
        public SelectList ProductCategories;

        private readonly IProductApplication _productAppilcation;
        private readonly IProductCategoryAppilcation _productCategoryAppilcation;

        public IndexModel(IProductApplication productAppilcation ,
            IProductCategoryAppilcation productCategoryAppilcation)
        {
            _productAppilcation = productAppilcation;
            _productCategoryAppilcation = productCategoryAppilcation;
        }

        public void OnGet(ProductSearchModel searchModel)
        {
            ProductCategories = new SelectList(_productCategoryAppilcation.GetProductCategories(),"Id","Name");
            Products = _productAppilcation.Search(searchModel);
        }
        public IActionResult OnGetCreate()
        {
            return Partial("./Create", new CreateProduct());
        }
        public JsonResult OnPostCreate(CreateProduct command)
        {
            var result = _productAppilcation.Create(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetEdit(long id)
        {
            var product = _productAppilcation.GetDetails(id);
            return Partial("Edit", product);
        }
        public JsonResult OnPostEdit(EditProduct command)
        {
            var result = _productAppilcation.Edit(command);
            return new JsonResult(result);
        }
    }
}
